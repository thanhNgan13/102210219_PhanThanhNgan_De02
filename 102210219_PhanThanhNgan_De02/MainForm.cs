using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102210219_PhanThanhNgan_De02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadData(getALLData());
        }
        public DataTable getALLData(string defaultQuerry = "")
        {
            string query;
            DataTable dataTable;
            if (defaultQuerry == "")
            {
                query = "\r\nSELECT BSP.MaSanPham,\r\nBSP.TenSanPham, BMH.NhaSanXuat, BSP.NgayNhapHang, " +
               "\r\nBMH.TenMatHang, BSP.TinhTrang" +
               "\r\nFROM dbo.Bang_San_Pham AS BSP, dbo.Bang_Mat_Hang AS BMH" +
               "\r\nWHERE BSP.MaMatHang = BMH.MaMatHang";
            }
            else
            {
                query = defaultQuerry;
            }

            dataTable = DataProvider.Instance.GetRecord(query);
            return (dataTable.Rows.Count > 0) ? dataTable : null;
        }
        
        public void loadData(DataTable dt)
        {
            int d = 1;
          
            if (getALLData() != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = d.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = Convert.ToBoolean(item[5].ToString());
                    d++;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
        }

        private DataTable Sort(int properties)
        {
            DataTable dataTable = getALLData();
            DataView dv = dataTable.DefaultView;
            switch (properties)
            {
                case 0:
                    dv.Sort = "TenSanPham asc";
                    break;
                case 1:
                    dv.Sort = "NgayNhapHang asc";
                    break;
                case 2:
                    dv.Sort = "TenSanPham desc";
                    break;
                case 3:
                    dv.Sort = "NgayNhapHang desc";
                    break;
            }
            DataTable sortedTable = dv.ToTable();
            return sortedTable;
        }

        private void buttonSORT_Click(object sender, EventArgs e)
        {
            if (comboBoxSORT.SelectedIndex >= 0)
            {
                DataTable dt = Sort(comboBoxSORT.SelectedIndex);
                dataGridView1.Rows.Clear();
                loadData(dt);
            }
            else
            {
                MessageBox.Show("Chưa chọn thuộc tính cần sắp xếp!");
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string mmh = row.Cells[1].Value.ToString();
                string request = string.Format("DELETE FROM dbo.Bang_San_Pham WHERE dbo.Bang_San_Pham.MaSanPham LIKE '{0}'", mmh);
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (DataProvider.Instance.ExecuteQuery(request) == true)
                    {
                        MessageBox.Show("Đã xóa thành công");
                        dataGridView1.Rows.Clear();
                        loadData(getALLData());
                    }
                    else
                    {
                        MessageBox.Show("Xóa mặt hàng không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy xóa");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mặt hàng cần xóa");
            }
        }


        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string mmh = row.Cells[1].Value.ToString();
                AddForm addForm = new AddForm();
                addForm.MMH = mmh;
                this.Hide();
                addForm.ShowDialog();
           
            }
            else
            {
                MessageBox.Show("Chưa chọn mặt hàng cần chỉnh sửa");
            }
          
        }



        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            if (textBoxSEARCH.Text.ToString() == "")
            {
                MessageBox.Show("Hãy nhập tên mã sản phẩm cần tìm kiếm");
            }
            else
            {
                string query =string.Format("SELECT BSP.MaSanPham,\r\nBSP.TenSanPham, BMH.NhaSanXuat, BSP.NgayNhapHang, \r\nBMH.TenMatHang, BSP.TinhTrang\r\nFROM dbo.Bang_San_Pham AS BSP, dbo.Bang_Mat_Hang AS BMH\r\nWHERE BSP.MaMatHang = BMH.MaMatHang\r\nAND BSP.MaSanPham LIKE '{0}'",textBoxSEARCH.Text);
                DataTable dataTable = getALLData(query);
                if (dataTable != null)
                {
                    dataGridView1.Rows.Clear();
                    loadData(dataTable);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy");
                }
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.MMH = null;
            this.Hide();
            addForm.ShowDialog();
        }




    }
}
