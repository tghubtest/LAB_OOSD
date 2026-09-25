namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.lblDichVuSuDung = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuNgay.Location = new System.Drawing.Point(25, 23);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(61, 19);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(90, 20);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(125, 25);
            this.dtTu.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenNgay.Location = new System.Drawing.Point(235, 23);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(71, 19);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(310, 20);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(125, 25);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.Location = new System.Drawing.Point(460, 17);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(110, 30);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhieuDat.Location = new System.Drawing.Point(25, 65);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(89, 19);
            this.lblPhieuDat.TabIndex = 5;
            this.lblPhieuDat.Text = "Phiếu đặt: 28";
            // 
            // lblDangO
            // 
            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDangO.Location = new System.Drawing.Point(350, 65);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(68, 19);
            this.lblDangO.TabIndex = 6;
            this.lblDangO.Text = "Đang ở: 7";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHoaDon.Location = new System.Drawing.Point(25, 100);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(82, 19);
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Hóa đơn: 21";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoanhThu.Location = new System.Drawing.Point(350, 100);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(201, 19);
            this.lblDoanhThu.TabIndex = 8;
            this.lblDoanhThu.Text = "Doanh thu HĐ: 52.600.000 đ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenBu.Location = new System.Drawing.Point(25, 135);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(171, 19);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Tổng đền bù: 2.100.000 đ";
            // 
            // lblDichVuSuDung
            // 
            this.lblDichVuSuDung.AutoSize = true;
            this.lblDichVuSuDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDichVuSuDung.Location = new System.Drawing.Point(25, 175);
            this.lblDichVuSuDung.Name = "lblDichVuSuDung";
            this.lblDichVuSuDung.Size = new System.Drawing.Size(117, 19);
            this.lblDichVuSuDung.TabIndex = 10;
            this.lblDichVuSuDung.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(25, 200);
            this.dgvDV.MultiSelect = false;
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersVisible = false;
            this.dgvDV.RowTemplate.Height = 30;
            this.dgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.Size = new System.Drawing.Size(700, 200);
            this.dgvDV.TabIndex = 11;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDichVuSuDung);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê khách sạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.Label lblDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.Label lblDichVuSuDung;
        private System.Windows.Forms.DataGridView dgvDV;
    }
}