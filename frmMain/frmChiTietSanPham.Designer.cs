namespace frmMain
{
    partial class frmChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietSanPham));
            this.gChiTietDatBao = new System.Windows.Forms.GroupBox();
            this.btnDeleteTC = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTC = new DevExpress.XtraEditors.SimpleButton();
            this.nudThangBD = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dgvCTDB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTapChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gPhieuDatBao = new System.Windows.Forms.GroupBox();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDB = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gChiTietDatBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).BeginInit();
            this.gPhieuDatBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gChiTietDatBao
            // 
            this.gChiTietDatBao.Controls.Add(this.btnDeleteTC);
            this.gChiTietDatBao.Controls.Add(this.btnAddTC);
            this.gChiTietDatBao.Controls.Add(this.nudThangBD);
            this.gChiTietDatBao.Controls.Add(this.nudSoLuong);
            this.gChiTietDatBao.Controls.Add(this.dgvCTDB);
            this.gChiTietDatBao.Controls.Add(this.txtTong);
            this.gChiTietDatBao.Controls.Add(this.cbTapChi);
            this.gChiTietDatBao.Controls.Add(this.label11);
            this.gChiTietDatBao.Controls.Add(this.label10);
            this.gChiTietDatBao.Controls.Add(this.label9);
            this.gChiTietDatBao.Controls.Add(this.label8);
            this.gChiTietDatBao.Controls.Add(this.label7);
            this.gChiTietDatBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gChiTietDatBao.Location = new System.Drawing.Point(19, 242);
            this.gChiTietDatBao.Name = "gChiTietDatBao";
            this.gChiTietDatBao.Size = new System.Drawing.Size(835, 200);
            this.gChiTietDatBao.TabIndex = 4;
            this.gChiTietDatBao.TabStop = false;
            this.gChiTietDatBao.Text = "Danh Sách Sản Phẩm";
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTC.ImageOptions.Image")));
            this.btnDeleteTC.Location = new System.Drawing.Point(661, 21);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteTC.TabIndex = 32;
            this.btnDeleteTC.Text = "Delete";
            // 
            // btnAddTC
            // 
            this.btnAddTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTC.ImageOptions.Image")));
            this.btnAddTC.Location = new System.Drawing.Point(569, 19);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(73, 38);
            this.btnAddTC.TabIndex = 31;
            this.btnAddTC.Text = "Add";
            // 
            // nudThangBD
            // 
            this.nudThangBD.Location = new System.Drawing.Point(381, 26);
            this.nudThangBD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThangBD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangBD.Name = "nudThangBD";
            this.nudThangBD.Size = new System.Drawing.Size(53, 20);
            this.nudThangBD.TabIndex = 30;
            this.nudThangBD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(262, 28);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(53, 20);
            this.nudSoLuong.TabIndex = 28;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvCTDB
            // 
            this.dgvCTDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTapChi,
            this.ThangBatDau,
            this.ThangKetThuc,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvCTDB.Location = new System.Drawing.Point(6, 91);
            this.dgvCTDB.Name = "dgvCTDB";
            this.dgvCTDB.Size = new System.Drawing.Size(820, 150);
            this.dgvCTDB.TabIndex = 27;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenTapChi
            // 
            this.TenTapChi.DataPropertyName = "TenTC";
            this.TenTapChi.HeaderText = "Tên Tạp Chí";
            this.TenTapChi.Name = "TenTapChi";
            this.TenTapChi.ReadOnly = true;
            // 
            // ThangBatDau
            // 
            this.ThangBatDau.DataPropertyName = "ThangBD";
            this.ThangBatDau.HeaderText = "Tháng Bắt Đầu";
            this.ThangBatDau.Name = "ThangBatDau";
            this.ThangBatDau.Width = 150;
            // 
            // ThangKetThuc
            // 
            this.ThangKetThuc.DataPropertyName = "ThangKT";
            this.ThangKetThuc.HeaderText = "Tháng Kết Thúc";
            this.ThangKetThuc.Name = "ThangKetThuc";
            this.ThangKetThuc.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(82, 65);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 23;
            // 
            // cbTapChi
            // 
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(118, 26);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(89, 21);
            this.cbTapChi.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(431, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(205, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Số Lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tổng Tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(321, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đơn Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm Tên Sản Phẩm:";
            // 
            // gPhieuDatBao
            // 
            this.gPhieuDatBao.Controls.Add(this.btnFirst);
            this.gPhieuDatBao.Controls.Add(this.btnPrevious);
            this.gPhieuDatBao.Controls.Add(this.btnNext);
            this.gPhieuDatBao.Controls.Add(this.btnLast);
            this.gPhieuDatBao.Controls.Add(this.btnExit);
            this.gPhieuDatBao.Controls.Add(this.btnDeleteDB);
            this.gPhieuDatBao.Controls.Add(this.btnCancel);
            this.gPhieuDatBao.Controls.Add(this.btnUpdateDB);
            this.gPhieuDatBao.Controls.Add(this.btnSave);
            this.gPhieuDatBao.Controls.Add(this.btnNewDB);
            this.gPhieuDatBao.Controls.Add(this.txtDiaChi);
            this.gPhieuDatBao.Controls.Add(this.txtTenKH);
            this.gPhieuDatBao.Controls.Add(this.label6);
            this.gPhieuDatBao.Controls.Add(this.label5);
            this.gPhieuDatBao.Controls.Add(this.label4);
            this.gPhieuDatBao.Controls.Add(this.label3);
            this.gPhieuDatBao.Controls.Add(this.dtNgayDat);
            this.gPhieuDatBao.Controls.Add(this.txtSoPhieu);
            this.gPhieuDatBao.Controls.Add(this.cbSDT);
            this.gPhieuDatBao.Controls.Add(this.label2);
            this.gPhieuDatBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gPhieuDatBao.Location = new System.Drawing.Point(19, 51);
            this.gPhieuDatBao.Name = "gPhieuDatBao";
            this.gPhieuDatBao.Size = new System.Drawing.Size(835, 185);
            this.gPhieuDatBao.TabIndex = 3;
            this.gPhieuDatBao.TabStop = false;
            this.gPhieuDatBao.Text = "Chi Tiết Sản Phẩm";
            // 
            // btnFirst
            // 
            this.btnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.ImageOptions.Image")));
            this.btnFirst.Location = new System.Drawing.Point(35, 138);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(41, 23);
            this.btnFirst.TabIndex = 35;
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ImageOptions.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(82, 138);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 23);
            this.btnPrevious.TabIndex = 34;
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.Location = new System.Drawing.Point(124, 138);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 23);
            this.btnNext.TabIndex = 33;
            // 
            // btnLast
            // 
            this.btnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.ImageOptions.Image")));
            this.btnLast.Location = new System.Drawing.Point(173, 138);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(45, 23);
            this.btnLast.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(643, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 28);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDB.ImageOptions.Image")));
            this.btnDeleteDB.Location = new System.Drawing.Point(548, 107);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(79, 32);
            this.btnDeleteDB.TabIndex = 26;
            this.btnDeleteDB.Text = "Delete";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(633, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDB.ImageOptions.Image")));
            this.btnUpdateDB.Location = new System.Drawing.Point(548, 70);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(79, 31);
            this.btnUpdateDB.TabIndex = 24;
            this.btnUpdateDB.Text = "Update";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(633, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            // 
            // btnNewDB
            // 
            this.btnNewDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDB.ImageOptions.Image")));
            this.btnNewDB.Location = new System.Drawing.Point(548, 30);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(70, 34);
            this.btnNewDB.TabIndex = 3;
            this.btnNewDB.Text = "New";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(324, 63);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 50);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(118, 91);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(264, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(214, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Đặt Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm Theo SĐT:";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(304, 27);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(200, 20);
            this.dtNgayDat.TabIndex = 3;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(99, 27);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 20);
            this.txtSoPhieu.TabIndex = 2;
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(106, 58);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(111, 21);
            this.cbSDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Số Phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // frmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gChiTietDatBao);
            this.Controls.Add(this.gPhieuDatBao);
            this.Name = "frmChiTietSanPham";
            this.Text = "frmChiTietSanPham";
            this.gChiTietDatBao.ResumeLayout(false);
            this.gChiTietDatBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).EndInit();
            this.gPhieuDatBao.ResumeLayout(false);
            this.gPhieuDatBao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gChiTietDatBao;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTC;
        private DevExpress.XtraEditors.SimpleButton btnAddTC;
        private System.Windows.Forms.NumericUpDown nudThangBD;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DataGridView dgvCTDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTapChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gPhieuDatBao;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDB;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDB;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNewDB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}