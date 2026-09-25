namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            this.lblPhieuLuutru = new System.Windows.Forms.Label();
            this.txtPhieuLuutru = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhieuLuutru
            // 
            this.lblPhieuLuutru.AutoSize = true;
            this.lblPhieuLuutru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhieuLuutru.Location = new System.Drawing.Point(15, 18);
            this.lblPhieuLuutru.Name = "lblPhieuLuutru";
            this.lblPhieuLuutru.Size = new System.Drawing.Size(78, 15);
            this.lblPhieuLuutru.TabIndex = 0;
            this.lblPhieuLuutru.Text = "Phiếu lưu trú:";
            // 
            // txtPhieuLuutru
            // 
            this.txtPhieuLuutru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhieuLuutru.Location = new System.Drawing.Point(95, 15);
            this.txtPhieuLuutru.Name = "txtPhieuLuutru";
            this.txtPhieuLuutru.Size = new System.Drawing.Size(100, 23);
            this.txtPhieuLuutru.TabIndex = 1;
            this.txtPhieuLuutru.Text = "DP001";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhong.Location = new System.Drawing.Point(210, 18);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(45, 15);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhong.Location = new System.Drawing.Point(258, 15);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(75, 23);
            this.txtPhong.TabIndex = 3;
            this.txtPhong.Text = "A101";
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDichVu.Location = new System.Drawing.Point(348, 18);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(50, 15);
            this.lblDichVu.TabIndex = 4;
            this.lblDichVu.Text = "Dịch vụ:";
            // 
            // txtDichVu
            // 
            this.txtDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDichVu.Location = new System.Drawing.Point(400, 15);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(130, 23);
            this.txtDichVu.TabIndex = 5;
            this.txtDichVu.Text = "Ăn sáng";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgay.Location = new System.Drawing.Point(15, 48);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(83, 15);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày sử dụng:";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(100, 45);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(95, 23);
            this.dtNgay.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuong.Location = new System.Drawing.Point(210, 48);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(270, 45);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(63, 23);
            this.numSoLuong.TabIndex = 9;
            this.numSoLuong.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGhiNhan.Location = new System.Drawing.Point(400, 42);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(130, 27);
            this.btnGhiNhan.TabIndex = 10;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(15, 80);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowTemplate.Height = 22;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(515, 200);
            this.dgvLichSu.TabIndex = 11;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 295);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtPhieuLuutru);
            this.Controls.Add(this.lblPhieuLuutru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPhieuLuutru;
        private System.Windows.Forms.TextBox txtPhieuLuutru;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}