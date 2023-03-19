using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _102210219_PhanThanhNgan_De02
{
    public partial class AddForm : Form
    {
        public string MMH { get; set; }
        public AddForm()
        {
            InitializeComponent();

        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Dispose();
            mainForm.ShowDialog();
        }

        public static List<string> getMatHang()
        {
            string query = "SELECT dbo.Bang_Mat_Hang.TenMatHang FROM dbo.Bang_Mat_Hang";
            DataTable dt = DataProvider.Instance.GetRecord(query);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["TenMatHang"].ToString());
            }
            return list;
        }
        public static List<string> getNhaSX(string matHang)
        {
            string query = string.Format("SELECT dbo.Bang_Mat_Hang.NhaSanXuat FROM dbo.Bang_Mat_Hang WHERE TenMatHang LIKE N'{0}'", matHang);
            DataTable dt = DataProvider.Instance.GetRecord(query);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["NhaSanXuat"].ToString());
            }
            return list;
        }
        public string getMaMatHang(string matHang)
        {
            string query = string.Format("SELECT dbo.Bang_Mat_Hang.MaMatHang FROM dbo.Bang_Mat_Hang\r\nWHERE TenMatHang LIKE N'{0}'", matHang);
            DataTable dt = DataProvider.Instance.GetRecord(query);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["MaMatHang"].ToString());
            }
            return list[0];

        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            if(MMH == null)
            {
                textBoxMASANPHAM.Enabled = true;
            }
            else
            {
                textBoxMASANPHAM.Enabled = false;
                textBoxMASANPHAM.Text = MMH;
            }
            comboBoxMATHANG.Items.AddRange(getMatHang().ToArray());
        }

        private void comboBoxMATHANG_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNHASX.Items.Clear();
            if (comboBoxMATHANG.SelectedIndex == -1)
            {
                comboBoxNHASX.SelectedIndex = -1;

            }
            else
            {
                comboBoxNHASX.Items.AddRange(getNhaSX(comboBoxMATHANG.SelectedItem.ToString()).ToArray());
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxMASANPHAM.Text == null || textBoxTENSANPHAM.Text == null
                || comboBoxMATHANG.SelectedItem == null || comboBoxNHASX.SelectedItem == null
                || (radioButtonCONHANG.Checked == false && radioButtonHETHANG.Checked == false) || textBoxMASANPHAM.Text.Length != 4 )
            {
                MessageBox.Show("Chưa nhập thông tin hoặc thông tin nhập chưa chuẩn xác");

            }
            else
            {
                MainForm mainForm = new MainForm();
                string request = string.Format("INSERT INTO dbo.Bang_San_Pham\r\n(\r\n    " +
                    "MaSanPham," +
                    "TenSanPham," +
                    "NgayNhapHang," +
                    "TinhTrang," +
                    "MaMatHang)" +
                    "VALUES('{0}', N'{1}', '{2}', {3}, '{4}')", textBoxMASANPHAM.Text.ToString(), textBoxTENSANPHAM.Text.ToString(),
                    dateTimePicker1.Value, radioButtonCONHANG.Checked ? "1" : "0", getMaMatHang(comboBoxMATHANG.SelectedItem.ToString()));

                if (MMH == null)
                {
                    if (DataProvider.Instance.ExecuteQuery(request))
                    {
                        DialogResult result = MessageBox.Show("Thêm thành công! Bạn có muốn tiếp tục thêm"  , "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            textBoxMASANPHAM.Text = "";
                            textBoxTENSANPHAM.Text = "";
                            comboBoxNHASX.SelectedIndex = -1;
                            comboBoxMATHANG.SelectedIndex = -1;
                            radioButtonCONHANG.Checked = false;
                            radioButtonHETHANG.Checked = false;
                        }
                        else if (result == DialogResult.No)
                        {
                            this.Hide();
                            mainForm.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                else
                {
                    string request1 = string.Format("UPDATE dbo.Bang_San_Pham SET TenSanPham = N'{0}', NgayNhapHang = '{1}', TinhTrang = {2}, " +
                        "MaMatHang = '{3}' WHERE MaSanPham LIKE '{4}'", textBoxTENSANPHAM.Text.ToString(),
                        dateTimePicker1.Value,
                        radioButtonCONHANG.Checked ? "1" : "0",
                         getMaMatHang(comboBoxMATHANG.SelectedItem.ToString()), textBoxMASANPHAM.Text.ToString());

                    if (DataProvider.Instance.ExecuteQuery(request1))
                    {
                        MessageBox.Show("Thay đổi thông tin thành công");
                        this.Hide();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                    
            }
        }


    }
}
