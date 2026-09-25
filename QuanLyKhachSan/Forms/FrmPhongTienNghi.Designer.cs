namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            this.lblMenuPhong = new System.Windows.Forms.Label();
            this.lblMenuTienNghi = new System.Windows.Forms.Label();
            this.lblMenuLapDat = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.txtKhu = new System.Windows.Forms.TextBox();
            this.lblSoNguoiToiDa = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lblPhieuLapDat = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblTienNghi = new System.Windows.Forms.Label();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.lblPhongLD = new System.Windows.Forms.Label();
            this.txtPhongLD = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuPhong
            // 
            this.lblMenuPhong.AutoSize = true;
            this.lblMenuPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblMenuPhong.Location = new System.Drawing.Point(25, 15);
            this.lblMenuPhong.Name = "lblMenuPhong";
            this.lblMenuPhong.Size = new System.Drawing.Size(63, 23);
            this.lblMenuPhong.TabIndex = 0;
            this.lblMenuPhong.Text = "[Phòng]";
            // 
            // lblMenuTienNghi
            // 
            this.lblMenuTienNghi.AutoSize = true;
            this.lblMenuTienNghi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuTienNghi.Location = new System.Drawing.Point(95, 15);
            this.lblMenuTienNghi.Name = "lblMenuTienNghi";
            this.lblMenuTienNghi.Size = new System.Drawing.Size(91, 23);
            this.lblMenuTienNghi.TabIndex = 1;
            this.lblMenuTienNghi.Text = "[Tiện nghi]";
            // 
            // lblMenuLapDat
            // 
            this.lblMenuLapDat.AutoSize = true;
            this.lblMenuLapDat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuLapDat.Location = new System.Drawing.Point(190, 15);
            this.lblMenuLapDat.Name = "lblMenuLapDat";
            this.lblMenuLapDat.Size = new System.Drawing.Size(182, 23);
            this.lblMenuLapDat.TabIndex = 2;
            this.lblMenuLapDat.Text = "[Lắp đặt / luân chuyển]";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhong.Location = new System.Drawing.Point(25, 55);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(88, 23);
            this.lblSoPhong.TabIndex = 3;
            this.lblSoPhong.Text = "Số phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhong.Location = new System.Drawing.Point(115, 52);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(150, 29);
            this.txtPhong.TabIndex = 4;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhuVuc.Location = new System.Drawing.Point(285, 55);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(75, 23);
            this.lblKhuVuc.TabIndex = 5;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // txtKhu
            // 
            this.txtKhu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhu.Location = new System.Drawing.Point(365, 52);
            this.txtKhu.Name = "txtKhu";
            this.txtKhu.Size = new System.Drawing.Size(150, 29);
            this.txtKhu.TabIndex = 6;
            // 
            // lblSoNguoiToiDa
            // 
            this.lblSoNguoiToiDa.AutoSize = true;
            this.lblSoNguoiToiDa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoNguoiToiDa.Location = new System.Drawing.Point(535, 55);
            this.lblSoNguoiToiDa.Name = "lblSoNguoiToiDa";
            this.lblSoNguoiToiDa.Size = new System.Drawing.Size(130, 23);
            this.lblSoNguoiToiDa.TabIndex = 7;
            this.lblSoNguoiToiDa.Text = "Số người tối đa:";
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMax.Location = new System.Drawing.Point(665, 52);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(85, 29);
            this.txtMax.TabIndex = 8;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDonGia.Location = new System.Drawing.Point(765, 55);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(120, 23);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "Đơn giá/ngày:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGia.Location = new System.Drawing.Point(885, 52);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(130, 29);
            this.txtGia.TabIndex = 10;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeight = 32;
            this.dgvPhong.Location = new System.Drawing.Point(25, 95);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowTemplate.Height = 35;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(990, 290);
            this.dgvPhong.TabIndex = 11;
            // 
            // lblPhieuLapDat
            // 
            this.lblPhieuLapDat.AutoSize = true;
            this.lblPhieuLapDat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhieuLapDat.Location = new System.Drawing.Point(25, 408);
            this.lblPhieuLapDat.Name = "lblPhieuLapDat";
            this.lblPhieuLapDat.Size = new System.Drawing.Size(115, 23);
            this.lblPhieuLapDat.TabIndex = 12;
            this.lblPhieuLapDat.Text = "Phiếu lắp đặt:";
            // 
            // txtSoLD
            // 
            this.txtSoLD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLD.Location = new System.Drawing.Point(145, 405);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(130, 29);
            this.txtSoLD.TabIndex = 13;
            this.txtSoLD.Text = "LD001";
            // 
            // lblTienNghi
            // 
            this.lblTienNghi.AutoSize = true;
            this.lblTienNghi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTienNghi.Location = new System.Drawing.Point(295, 408);
            this.lblTienNghi.Name = "lblTienNghi";
            this.lblTienNghi.Size = new System.Drawing.Size(84, 23);
            this.lblTienNghi.TabIndex = 14;
            this.lblTienNghi.Text = "Tiện nghi:";
            // 
            // txtTN
            // 
            this.txtTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTN.Location = new System.Drawing.Point(380, 405);
            this.txtTN.Name = "txtTN";
            this.txtTN.Size = new System.Drawing.Size(130, 29);
            this.txtTN.TabIndex = 15;
            this.txtTN.Text = "TV01";
            // 
            // lblPhongLD
            // 
            this.lblPhongLD.AutoSize = true;
            this.lblPhongLD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhongLD.Location = new System.Drawing.Point(530, 408);
            this.lblPhongLD.Name = "lblPhongLD";
            this.lblPhongLD.Size = new System.Drawing.Size(64, 23);
            this.lblPhongLD.TabIndex = 16;
            this.lblPhongLD.Text = "Phòng:";
            // 
            // txtPhongLD
            // 
            this.txtPhongLD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhongLD.Location = new System.Drawing.Point(595, 405);
            this.txtPhongLD.Name = "txtPhongLD";
            this.txtPhongLD.Size = new System.Drawing.Size(110, 29);
            this.txtPhongLD.TabIndex = 17;
            this.txtPhongLD.Text = "A101";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTinhTrang.Location = new System.Drawing.Point(720, 408);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(92, 23);
            this.lblTinhTrang.TabIndex = 18;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTinhTrang.Location = new System.Drawing.Point(815, 405);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(200, 29);
            this.txtTinhTrang.TabIndex = 19;
            this.txtTinhTrang.Text = "Tốt";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLapPhieu.Location = new System.Drawing.Point(865, 450);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(150, 38);
            this.btnLapPhieu.TabIndex = 20;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 505);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.txtPhongLD);
            this.Controls.Add(this.lblPhongLD);
            this.Controls.Add(this.txtTN);
            this.Controls.Add(this.lblTienNghi);
            this.Controls.Add(this.txtSoLD);
            this.Controls.Add(this.lblPhieuLapDat);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblSoNguoiToiDa);
            this.Controls.Add(this.txtKhu);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.lblMenuLapDat);
            this.Controls.Add(this.lblMenuTienNghi);
            this.Controls.Add(this.lblMenuPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMenuPhong;
        private System.Windows.Forms.Label lblMenuTienNghi;
        private System.Windows.Forms.Label lblMenuLapDat;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.TextBox txtKhu;
        private System.Windows.Forms.Label lblSoNguoiToiDa;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblPhieuLapDat;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label lblTienNghi;
        private System.Windows.Forms.TextBox txtTN;
        private System.Windows.Forms.Label lblPhongLD;
        private System.Windows.Forms.TextBox txtPhongLD;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnLapPhieu;
    }
}