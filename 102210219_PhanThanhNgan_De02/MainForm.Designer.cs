namespace _102210219_PhanThanhNgan_De02
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.buttonSORT = new System.Windows.Forms.Button();
            this.textBoxSEARCH = new System.Windows.Forms.TextBox();
            this.comboBoxSORT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSanPham,
            this.TenSanPham,
            this.NhaSX,
            this.NgayNhapHang,
            this.TenMatHang,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // NhaSX
            // 
            this.NhaSX.HeaderText = "Nhà SX";
            this.NhaSX.MinimumWidth = 6;
            this.NhaSX.Name = "NhaSX";
            this.NhaSX.ReadOnly = true;
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.HeaderText = "Ngày Nhập";
            this.NgayNhapHang.MinimumWidth = 6;
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.ReadOnly = true;
            // 
            // TenMatHang
            // 
            this.TenMatHang.HeaderText = "Mặt Hàng";
            this.TenMatHang.MinimumWidth = 6;
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(214, 323);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(93, 43);
            this.buttonADD.TabIndex = 1;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(388, 323);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(93, 43);
            this.buttonUPDATE.TabIndex = 2;
            this.buttonUPDATE.Text = "Update";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(545, 323);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(93, 43);
            this.buttonDELETE.TabIndex = 3;
            this.buttonDELETE.Text = "Delete";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.Location = new System.Drawing.Point(782, 323);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(93, 43);
            this.buttonSEARCH.TabIndex = 4;
            this.buttonSEARCH.Text = "Search";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            this.buttonSEARCH.Click += new System.EventHandler(this.buttonSEARCH_Click);
            // 
            // buttonSORT
            // 
            this.buttonSORT.Location = new System.Drawing.Point(28, 445);
            this.buttonSORT.Name = "buttonSORT";
            this.buttonSORT.Size = new System.Drawing.Size(93, 43);
            this.buttonSORT.TabIndex = 5;
            this.buttonSORT.Text = "Sort";
            this.buttonSORT.UseVisualStyleBackColor = true;
            this.buttonSORT.Click += new System.EventHandler(this.buttonSORT_Click);
            // 
            // textBoxSEARCH
            // 
            this.textBoxSEARCH.Location = new System.Drawing.Point(906, 333);
            this.textBoxSEARCH.Name = "textBoxSEARCH";
            this.textBoxSEARCH.Size = new System.Drawing.Size(257, 22);
            this.textBoxSEARCH.TabIndex = 6;
            // 
            // comboBoxSORT
            // 
            this.comboBoxSORT.FormattingEnabled = true;
            this.comboBoxSORT.Items.AddRange(new object[] {
            "Ascending: Tên Sản Phẩm",
            "Ascending: Ngày Nhập",
            "Descending: Tên Sản Phẩm",
            "Descending: Ngày Nhập"});
            this.comboBoxSORT.Location = new System.Drawing.Point(156, 455);
            this.comboBoxSORT.Name = "comboBoxSORT";
            this.comboBoxSORT.Size = new System.Drawing.Size(226, 24);
            this.comboBoxSORT.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 559);
            this.Controls.Add(this.comboBoxSORT);
            this.Controls.Add(this.textBoxSEARCH);
            this.Controls.Add(this.buttonSORT);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.Button buttonSORT;
        private System.Windows.Forms.TextBox textBoxSEARCH;
        private System.Windows.Forms.ComboBox comboBoxSORT;
    }
}