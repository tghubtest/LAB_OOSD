namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.lblMenuKhachHang = new System.Windows.Forms.Label();
            this.lblMenuDatPhong = new System.Windows.Forms.Label();
            this.lblMenuNhanPhong = new System.Windows.Forms.Label();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.txtKhach = new System.Windows.Forms.TextBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.lblPhieuDatPhong = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuKhachHang
            // 
            this.lblMenuKhachHang.AutoSize = true;
            this.lblMenuKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuKhachHang.Location = new System.Drawing.Point(40, 29);
            this.lblMenuKhachHang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMenuKhachHang.Name = "lblMenuKhachHang";
            this.lblMenuKhachHang.Size = new System.Drawing.Size(172, 37);
            this.lblMenuKhachHang.TabIndex = 0;
            this.lblMenuKhachHang.Text = "[Khách hàng]";
            // 
            // lblMenuDatPhong
            // 
            this.lblMenuDatPhong.AutoSize = true;
            this.lblMenuDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuDatPhong.Location = new System.Drawing.Point(240, 29);
            this.lblMenuDatPhong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMenuDatPhong.Name = "lblMenuDatPhong";
            this.lblMenuDatPhong.Size = new System.Drawing.Size(160, 37);
            this.lblMenuDatPhong.TabIndex = 1;
            this.lblMenuDatPhong.Text = "[Đặt phòng]";
            // 
            // lblMenuNhanPhong
            // 
            this.lblMenuNhanPhong.AutoSize = true;
            this.lblMenuNhanPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuNhanPhong.Location = new System.Drawing.Point(424, 29);
            this.lblMenuNhanPhong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMenuNhanPhong.Name = "lblMenuNhanPhong";
            this.lblMenuNhanPhong.Size = new System.Drawing.Size(367, 37);
            this.lblMenuNhanPhong.TabIndex = 2;
            this.lblMenuNhanPhong.Text = "[Nhận phòng / Người lưu trú]";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoPhieu.Location = new System.Drawing.Point(40, 102);
            this.lblSoPhieu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(173, 37);
            this.lblSoPhieu.TabIndex = 3;
            this.lblSoPhieu.Text = "Số phiếu đặt:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoPhieu.Location = new System.Drawing.Point(230, 96);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(236, 43);
            this.txtSoPhieu.TabIndex = 4;
            this.txtSoPhieu.Text = "DP001";
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhach.Location = new System.Drawing.Point(500, 102);
            this.lblKhach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(95, 37);
            this.lblKhach.TabIndex = 5;
            this.lblKhach.Text = "Khách:";
            // 
            // txtKhach
            // 
            this.txtKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhach.Location = new System.Drawing.Point(604, 96);
            this.txtKhach.Margin = new System.Windows.Forms.Padding(6);
            this.txtKhach.Name = "txtKhach";
            this.txtKhach.Size = new System.Drawing.Size(356, 43);
            this.txtKhach.TabIndex = 6;
            this.txtKhach.Text = "Nguyễn Văn A";
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKenh.Location = new System.Drawing.Point(990, 102);
            this.lblKenh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(129, 37);
            this.lblKenh.TabIndex = 7;
            this.lblKenh.Text = "Kênh đặt:";
            // 
            // cboKenh
            // 
            this.cboKenh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(1124, 96);
            this.cboKenh.Margin = new System.Windows.Forms.Padding(6);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(246, 45);
            this.cboKenh.TabIndex = 8;
            this.cboKenh.Text = "Website";
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCoc.Location = new System.Drawing.Point(1400, 102);
            this.lblCoc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(120, 37);
            this.lblCoc.TabIndex = 9;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // numCoc
            // 
            this.numCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCoc.Location = new System.Drawing.Point(1532, 96);
            this.numCoc.Margin = new System.Windows.Forms.Padding(6);
            this.numCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(200, 43);
            this.numCoc.TabIndex = 10;
            this.numCoc.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(40, 173);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 25;
            this.dgvPhong.RowTemplate.Height = 30;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(820, 337);
            this.dgvPhong.TabIndex = 11;
            // 
            // dgvChon
            // 
            this.dgvChon.AllowUserToAddRows = false;
            this.dgvChon.AllowUserToDeleteRows = false;
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(890, 173);
            this.dgvChon.Margin = new System.Windows.Forms.Padding(6);
            this.dgvChon.MultiSelect = false;
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.ReadOnly = true;
            this.dgvChon.RowHeadersWidth = 25;
            this.dgvChon.RowTemplate.Height = 30;
            this.dgvChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChon.Size = new System.Drawing.Size(840, 337);
            this.dgvChon.TabIndex = 12;
            this.dgvChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChon_CellContentClick);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLapPhieu.Location = new System.Drawing.Point(1430, 529);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(300, 62);
            this.btnLapPhieu.TabIndex = 13;
            this.btnLapPhieu.Text = "Lập phiếu đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // lblPhieuDatPhong
            // 
            this.lblPhieuDatPhong.AutoSize = true;
            this.lblPhieuDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhieuDatPhong.Location = new System.Drawing.Point(40, 612);
            this.lblPhieuDatPhong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhieuDatPhong.Name = "lblPhieuDatPhong";
            this.lblPhieuDatPhong.Size = new System.Drawing.Size(220, 37);
            this.lblPhieuDatPhong.TabIndex = 14;
            this.lblPhieuDatPhong.Text = "Phiếu đặt phòng:";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(40, 658);
            this.dgvPhieu.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 25;
            this.dgvPhieu.RowTemplate.Height = 30;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(1690, 269);
            this.dgvPhieu.TabIndex = 15;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 952);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.lblPhieuDatPhong);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.dgvChon);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.numCoc);
            this.Controls.Add(this.lblCoc);
            this.Controls.Add(this.cboKenh);
            this.Controls.Add(this.lblKenh);
            this.Controls.Add(this.txtKhach);
            this.Controls.Add(this.lblKhach);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.lblSoPhieu);
            this.Controls.Add(this.lblMenuNhanPhong);
            this.Controls.Add(this.lblMenuDatPhong);
            this.Controls.Add(this.lblMenuKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuKhachHang;
        private System.Windows.Forms.Label lblMenuDatPhong;
        private System.Windows.Forms.Label lblMenuNhanPhong;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.TextBox txtKhach;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblPhieuDatPhong;
        private System.Windows.Forms.DataGridView dgvPhieu;
    }
}