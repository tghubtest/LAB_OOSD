namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            this.lblMenuKhuVuc = new System.Windows.Forms.Label();
            this.lblMenuNhanVien = new System.Windows.Forms.Label();
            this.lblMenuLoaiTN = new System.Windows.Forms.Label();
            this.lblMenuDichVu = new System.Windows.Forms.Label();
            this.lblMenuQuyDinh = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDonViVaiTro = new System.Windows.Forms.Label();
            this.txtDonViVaiTro = new System.Windows.Forms.TextBox();
            this.cboLoaiTN = new System.Windows.Forms.ComboBox();
            this.lblGiaMuc = new System.Windows.Forms.Label();
            this.numGiaMuc = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuKhuVuc
            // 
            this.lblMenuKhuVuc.AutoSize = true;
            this.lblMenuKhuVuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuKhuVuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuKhuVuc.Location = new System.Drawing.Point(20, 20);
            this.lblMenuKhuVuc.Name = "lblMenuKhuVuc";
            this.lblMenuKhuVuc.Size = new System.Drawing.Size(73, 19);
            this.lblMenuKhuVuc.TabIndex = 0;
            this.lblMenuKhuVuc.Text = "[ Khu vực ]";
            this.lblMenuKhuVuc.Click += new System.EventHandler(this.lblMenuKhuVuc_Click);
            // 
            // lblMenuNhanVien
            // 
            this.lblMenuNhanVien.AutoSize = true;
            this.lblMenuNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuNhanVien.Location = new System.Drawing.Point(100, 20);
            this.lblMenuNhanVien.Name = "lblMenuNhanVien";
            this.lblMenuNhanVien.Size = new System.Drawing.Size(86, 19);
            this.lblMenuNhanVien.TabIndex = 1;
            this.lblMenuNhanVien.Text = "[ Nhân viên ]";
            this.lblMenuNhanVien.Click += new System.EventHandler(this.lblMenuNhanVien_Click);
            // 
            // lblMenuLoaiTN
            // 
            this.lblMenuLoaiTN.AutoSize = true;
            this.lblMenuLoaiTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuLoaiTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuLoaiTN.Location = new System.Drawing.Point(195, 20);
            this.lblMenuLoaiTN.Name = "lblMenuLoaiTN";
            this.lblMenuLoaiTN.Size = new System.Drawing.Size(107, 19);
            this.lblMenuLoaiTN.TabIndex = 2;
            this.lblMenuLoaiTN.Text = "[ Loại tiện nghi ]";
            this.lblMenuLoaiTN.Click += new System.EventHandler(this.lblMenuLoaiTN_Click);
            // 
            // lblMenuDichVu
            // 
            this.lblMenuDichVu.AutoSize = true;
            this.lblMenuDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuDichVu.Location = new System.Drawing.Point(310, 20);
            this.lblMenuDichVu.Name = "lblMenuDichVu";
            this.lblMenuDichVu.Size = new System.Drawing.Size(76, 19);
            this.lblMenuDichVu.TabIndex = 3;
            this.lblMenuDichVu.Text = "[ Dịch vụ ]";
            this.lblMenuDichVu.Click += new System.EventHandler(this.lblMenuDichVu_Click);
            // 
            // lblMenuQuyDinh
            // 
            this.lblMenuQuyDinh.AutoSize = true;
            this.lblMenuQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuQuyDinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMenuQuyDinh.Location = new System.Drawing.Point(395, 20);
            this.lblMenuQuyDinh.Name = "lblMenuQuyDinh";
            this.lblMenuQuyDinh.Size = new System.Drawing.Size(130, 19);
            this.lblMenuQuyDinh.TabIndex = 4;
            this.lblMenuQuyDinh.Text = "[ Quy định đền bù ]";
            this.lblMenuQuyDinh.Click += new System.EventHandler(this.lblMenuQuyDinh_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMa.Location = new System.Drawing.Point(20, 60);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(32, 19);
            this.lblMa.TabIndex = 5;
            this.lblMa.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMa.Location = new System.Drawing.Point(60, 57);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(120, 25);
            this.txtMa.TabIndex = 6;
            this.txtMa.Text = "DV01";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTen.Location = new System.Drawing.Point(200, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(33, 19);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTen.Location = new System.Drawing.Point(240, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(160, 25);
            this.txtTen.TabIndex = 8;
            this.txtTen.Text = "Ăn sáng";
            // 
            // lblDonViVaiTro
            // 
            this.lblDonViVaiTro.AutoSize = true;
            this.lblDonViVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDonViVaiTro.Location = new System.Drawing.Point(420, 60);
            this.lblDonViVaiTro.Name = "lblDonViVaiTro";
            this.lblDonViVaiTro.Size = new System.Drawing.Size(102, 19);
            this.lblDonViVaiTro.TabIndex = 9;
            this.lblDonViVaiTro.Text = "Đơn vị / Vai trò:";
            // 
            // txtDonViVaiTro
            // 
            this.txtDonViVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonViVaiTro.Location = new System.Drawing.Point(530, 57);
            this.txtDonViVaiTro.Name = "txtDonViVaiTro";
            this.txtDonViVaiTro.Size = new System.Drawing.Size(120, 25);
            this.txtDonViVaiTro.TabIndex = 10;
            this.txtDonViVaiTro.Text = "Suất";
            // 
            // cboLoaiTN
            // 
            this.cboLoaiTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiTN.FormattingEnabled = true;
            this.cboLoaiTN.Location = new System.Drawing.Point(530, 57);
            this.cboLoaiTN.Name = "cboLoaiTN";
            this.cboLoaiTN.Size = new System.Drawing.Size(120, 25);
            this.cboLoaiTN.TabIndex = 11;
            this.cboLoaiTN.Visible = false;
            // 
            // lblGiaMuc
            // 
            this.lblGiaMuc.AutoSize = true;
            this.lblGiaMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaMuc.Location = new System.Drawing.Point(660, 60);
            this.lblGiaMuc.Name = "lblGiaMuc";
            this.lblGiaMuc.Size = new System.Drawing.Size(61, 19);
            this.lblGiaMuc.TabIndex = 12;
            this.lblGiaMuc.Text = "Đơn giá:";
            this.lblGiaMuc.Visible = false;
            // 
            // numGiaMuc
            // 
            this.numGiaMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numGiaMuc.Location = new System.Drawing.Point(725, 57);
            this.numGiaMuc.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGiaMuc.Name = "numGiaMuc";
            this.numGiaMuc.Size = new System.Drawing.Size(90, 25);
            this.numGiaMuc.TabIndex = 13;
            this.numGiaMuc.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThem.Location = new System.Drawing.Point(670, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(20, 100);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(740, 280);
            this.dgvDanhSach.TabIndex = 15;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numGiaMuc);
            this.Controls.Add(this.lblGiaMuc);
            this.Controls.Add(this.cboLoaiTN);
            this.Controls.Add(this.txtDonViVaiTro);
            this.Controls.Add(this.lblDonViVaiTro);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblMenuQuyDinh);
            this.Controls.Add(this.lblMenuDichVu);
            this.Controls.Add(this.lblMenuLoaiTN);
            this.Controls.Add(this.lblMenuNhanVien);
            this.Controls.Add(this.lblMenuKhuVuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách sạn";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGiaMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMenuKhuVuc;
        private System.Windows.Forms.Label lblMenuNhanVien;
        private System.Windows.Forms.Label lblMenuLoaiTN;
        private System.Windows.Forms.Label lblMenuDichVu;
        private System.Windows.Forms.Label lblMenuQuyDinh;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDonViVaiTro;
        private System.Windows.Forms.TextBox txtDonViVaiTro;
        private System.Windows.Forms.ComboBox cboLoaiTN;
        private System.Windows.Forms.Label lblGiaMuc;
        private System.Windows.Forms.NumericUpDown numGiaMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}