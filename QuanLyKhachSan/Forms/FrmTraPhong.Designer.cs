namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            this.lblPhieuDangO = new System.Windows.Forms.Label();
            this.txtPhieuDangO = new System.Windows.Forms.TextBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblSoTienDB = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnLapDenBu = new System.Windows.Forms.Button();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblSoTienTT = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhieuDangO
            // 
            this.lblPhieuDangO.AutoSize = true;
            this.lblPhieuDangO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhieuDangO.Location = new System.Drawing.Point(40, 38);
            this.lblPhieuDangO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhieuDangO.Name = "lblPhieuDangO";
            this.lblPhieuDangO.Size = new System.Drawing.Size(180, 37);
            this.lblPhieuDangO.TabIndex = 0;
            this.lblPhieuDangO.Text = "Phiếu đang ở:";
            // 
            // txtPhieuDangO
            // 
            this.txtPhieuDangO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhieuDangO.Location = new System.Drawing.Point(240, 33);
            this.txtPhieuDangO.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhieuDangO.Name = "txtPhieuDangO";
            this.txtPhieuDangO.Size = new System.Drawing.Size(276, 43);
            this.txtPhieuDangO.TabIndex = 1;
            this.txtPhieuDangO.Text = "DP001";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(40, 106);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 25;
            this.dgvPhong.RowTemplate.Height = 30;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(520, 250);
            this.dgvPhong.TabIndex = 2;
            // 
            // dgvTN
            // 
            this.dgvTN.AllowUserToAddRows = false;
            this.dgvTN.AllowUserToDeleteRows = false;
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.Color.White;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(580, 106);
            this.dgvTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvTN.MultiSelect = false;
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersWidth = 25;
            this.dgvTN.RowTemplate.Height = 30;
            this.dgvTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTN.Size = new System.Drawing.Size(620, 250);
            this.dgvTN.TabIndex = 3;
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AllowUserToAddRows = false;
            this.dgvDBChon.AllowUserToDeleteRows = false;
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Location = new System.Drawing.Point(1220, 106);
            this.dgvDBChon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDBChon.MultiSelect = false;
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.ReadOnly = true;
            this.dgvDBChon.RowHeadersWidth = 25;
            this.dgvDBChon.RowTemplate.Height = 30;
            this.dgvDBChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDBChon.Size = new System.Drawing.Size(640, 250);
            this.dgvDBChon.TabIndex = 4;
            // 
            // lblSoDB
            // 
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoDB.Location = new System.Drawing.Point(40, 390);
            this.lblSoDB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(217, 37);
            this.lblSoDB.TabIndex = 5;
            this.lblSoDB.Text = "Số phiếu đền bù:";
            // 
            // txtSoDB
            // 
            this.txtSoDB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDB.Location = new System.Drawing.Point(270, 385);
            this.txtSoDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(246, 43);
            this.txtSoDB.TabIndex = 6;
            this.txtSoDB.Text = "DB001";
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMucDo.Location = new System.Drawing.Point(560, 390);
            this.lblMucDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(114, 37);
            this.lblMucDo.TabIndex = 7;
            this.lblMucDo.Text = "Mức độ:";
            // 
            // txtMucDo
            // 
            this.txtMucDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMucDo.Location = new System.Drawing.Point(690, 385);
            this.txtMucDo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(276, 43);
            this.txtMucDo.TabIndex = 8;
            this.txtMucDo.Text = "Hư hỏng nhẹ";
            // 
            // lblSoTienDB
            // 
            this.lblSoTienDB.AutoSize = true;
            this.lblSoTienDB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoTienDB.Location = new System.Drawing.Point(1020, 390);
            this.lblSoTienDB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoTienDB.Name = "lblSoTienDB";
            this.lblSoTienDB.Size = new System.Drawing.Size(105, 37);
            this.lblSoTienDB.TabIndex = 9;
            this.lblSoTienDB.Text = "Số tiền:";
            // 
            // numDenBu
            // 
            this.numDenBu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDenBu.Location = new System.Drawing.Point(1140, 385);
            this.numDenBu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numDenBu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(250, 43);
            this.numDenBu.TabIndex = 10;
            this.numDenBu.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // btnLapDenBu
            // 
            this.btnLapDenBu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLapDenBu.Location = new System.Drawing.Point(1510, 377);
            this.btnLapDenBu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLapDenBu.Name = "btnLapDenBu";
            this.btnLapDenBu.Size = new System.Drawing.Size(350, 62);
            this.btnLapDenBu.TabIndex = 11;
            this.btnLapDenBu.Text = "Lập phiếu đền bù";
            this.btnLapDenBu.UseVisualStyleBackColor = true;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoHD.Location = new System.Drawing.Point(40, 471);
            this.lblSoHD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(159, 37);
            this.lblSoHD.TabIndex = 12;
            this.lblSoHD.Text = "Số hóa đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoHD.Location = new System.Drawing.Point(240, 465);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(276, 43);
            this.txtSoHD.TabIndex = 13;
            this.txtSoHD.Text = "HD001";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoNgay.Location = new System.Drawing.Point(560, 471);
            this.lblSoNgay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(223, 37);
            this.lblSoNgay.TabIndex = 14;
            this.lblSoNgay.Text = "Số ngày tính tiền:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSoNgay.Location = new System.Drawing.Point(806, 465);
            this.numSoNgay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(170, 43);
            this.numSoNgay.TabIndex = 15;
            this.numSoNgay.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnLapHD
            // 
            this.btnLapHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLapHD.Location = new System.Drawing.Point(1040, 458);
            this.btnLapHD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(260, 62);
            this.btnLapHD.TabIndex = 16;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(40, 538);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvHD.MultiSelect = false;
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 25;
            this.dgvHD.RowTemplate.Height = 30;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(1820, 288);
            this.dgvHD.TabIndex = 17;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHinhThuc.Location = new System.Drawing.Point(40, 862);
            this.lblHinhThuc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(138, 37);
            this.lblHinhThuc.TabIndex = 18;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Location = new System.Drawing.Point(200, 856);
            this.cboHinhThuc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(256, 45);
            this.cboHinhThuc.TabIndex = 19;
            this.cboHinhThuc.Text = "Thẻ";
            // 
            // lblSoTienTT
            // 
            this.lblSoTienTT.AutoSize = true;
            this.lblSoTienTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoTienTT.Location = new System.Drawing.Point(510, 862);
            this.lblSoTienTT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoTienTT.Name = "lblSoTienTT";
            this.lblSoTienTT.Size = new System.Drawing.Size(105, 37);
            this.lblSoTienTT.TabIndex = 20;
            this.lblSoTienTT.Text = "Số tiền:";
            // 
            // numTienTT
            // 
            this.numTienTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTienTT.Location = new System.Drawing.Point(630, 856);
            this.numTienTT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numTienTT.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(250, 43);
            this.numTienTT.TabIndex = 21;
            this.numTienTT.Value = new decimal(new int[] {
            1200000,
            0,
            0,
            0});
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThanhToan.Location = new System.Drawing.Point(960, 848);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(240, 62);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTraPhong.Location = new System.Drawing.Point(1260, 848);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(320, 62);
            this.btnTraPhong.TabIndex = 23;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 942);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.lblSoTienTT);
            this.Controls.Add(this.cboHinhThuc);
            this.Controls.Add(this.lblHinhThuc);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.btnLapDenBu);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.lblSoTienDB);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.lblSoDB);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.txtPhieuDangO);
            this.Controls.Add(this.lblPhieuDangO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuDangO;
        private System.Windows.Forms.TextBox txtPhieuDangO;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label lblSoTienDB;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnLapDenBu;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label lblSoTienTT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
    }
}