-- ============================================================================
-- CƠ SỞ DỮ LIỆU: QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT
-- Kiến trúc: SQL Server
-- Tác giả: Nguyễn Thị Thùy Trang
-- ============================================================================

IF DB_ID(N'QuanLyNuocGiaiKhat') IS NULL 
    CREATE DATABASE QuanLyNuocGiaiKhat;
GO

USE QuanLyNuocGiaiKhat;
GO

-- ----------------------------------------------------------------------------
-- 1. XÓA BẢNG CŨ NẾU ĐÃ TỒN TẠI (Đảm bảo thứ tự xóa ngược chiều khóa ngoại)
-- ----------------------------------------------------------------------------
IF OBJECT_ID('PhieuGhiNo', 'U') IS NOT NULL DROP TABLE PhieuGhiNo;
IF OBJECT_ID('ChiTietPhieuHenGiao', 'U') IS NOT NULL DROP TABLE ChiTietPhieuHenGiao;
IF OBJECT_ID('PhieuHenGiao', 'U') IS NOT NULL DROP TABLE PhieuHenGiao;
IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('ChiTietPhieuGiaoHang', 'U') IS NOT NULL DROP TABLE ChiTietPhieuGiaoHang;
IF OBJECT_ID('PhieuGiaoHang', 'U') IS NOT NULL DROP TABLE PhieuGiaoHang;
IF OBJECT_ID('ChiTietDonDatHang', 'U') IS NOT NULL DROP TABLE ChiTietDonDatHang;
IF OBJECT_ID('DonDatHang', 'U') IS NOT NULL DROP TABLE DonDatHang;
IF OBJECT_ID('NuocGiaiKhat', 'U') IS NOT NULL DROP TABLE NuocGiaiKhat;
IF OBJECT_ID('NhanHieu', 'U') IS NOT NULL DROP TABLE NhanHieu;
IF OBJECT_ID('NhaCungUng', 'U') IS NOT NULL DROP TABLE NhaCungUng;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
GO

-- ----------------------------------------------------------------------------
-- 2. TẠO CÁC BẢNG NỀN & DANH MỤC
-- ----------------------------------------------------------------------------

-- Bảng 1: Nhân Viên
CREATE TABLE NhanVien (
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(150) NOT NULL,
    SoDienThoai varchar(15) NULL
);

-- Bảng 2: Khách Hàng (Tích hợp Khách quen & Khách vãng lai - QD06)
CREATE TABLE KhachHang (
    MaKH varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(150) NOT NULL,
    DiaChi nvarchar(250) NULL,
    SoDienThoai varchar(15) NULL,
    LoaiKhach nvarchar(20) NOT NULL CHECK (LoaiKhach IN (N'Khách quen', N'Khách vãng lai'))
);

-- Bảng 3: Nhà Cung Ứng
CREATE TABLE NhaCungUng (
    MaNCC varchar(20) NOT NULL PRIMARY KEY,
    TenNCC nvarchar(150) NOT NULL,
    DiaChi nvarchar(250) NULL,
    SoDienThoai varchar(15) NULL
);

-- Bảng 4: Nhãn Hiệu (Loại NGK - QD01: Mỗi loại do 1 NCC cung cấp)
CREATE TABLE NhanHieu (
    MaLoai varchar(20) NOT NULL PRIMARY KEY,
    TenLoai nvarchar(100) NOT NULL UNIQUE,
    MaNCC varchar(20) NOT NULL,
    CONSTRAINT FK_NhanHieu_NhaCungUng FOREIGN KEY (MaNCC) REFERENCES NhaCungUng(MaNCC)
);

-- Bảng 5: Nước Giải Khát (QD02: Tồn kho không bao giờ âm)
CREATE TABLE NuocGiaiKhat (
    MaNGK varchar(20) NOT NULL PRIMARY KEY,
    TenNGK nvarchar(150) NOT NULL,
    DonViTinh nvarchar(20) NOT NULL,
    MaLoai varchar(20) NOT NULL,
    SoLuongTon int NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0),
    CONSTRAINT FK_NuocGiaiKhat_NhanHieu FOREIGN KEY (MaLoai) REFERENCES NhanHieu(MaLoai)
);

-- ----------------------------------------------------------------------------
-- 3. TẠO CÁC BẢNG MUA HÀNG TỪ NHÀ CUNG ỨNG
-- ----------------------------------------------------------------------------

-- Bảng 6: Đơn Đặt Hàng (Gửi nhà cung ứng)
CREATE TABLE DonDatHang (
    SoDDH varchar(20) NOT NULL PRIMARY KEY,
    MaNCC varchar(20) NOT NULL,
    MaNV varchar(20) NOT NULL,
    NgayDatHang date NOT NULL,
    NgayNhanHang date NOT NULL,
    CONSTRAINT FK_DonDatHang_NCC FOREIGN KEY (MaNCC) REFERENCES NhaCungUng(MaNCC),
    CONSTRAINT FK_DonDatHang_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng 7: Chi Tiết Đơn Đặt Hàng
CREATE TABLE ChiTietDonDatHang (
    SoDDH varchar(20) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongDat int NOT NULL CHECK (SoLuongDat > 0),
    PRIMARY KEY (SoDDH, MaNGK),
    CONSTRAINT FK_CTDDH_DDH FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT FK_CTDDH_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);

-- Bảng 8: Phiếu Giao Hàng (QD03: Tối đa 3 đợt giao từ NCC)
CREATE TABLE PhieuGiaoHang (
    SoPhieuGiao varchar(20) NOT NULL PRIMARY KEY,
    SoDDH varchar(20) NOT NULL,
    DotGiao tinyint NOT NULL CHECK (DotGiao BETWEEN 1 AND 3),
    NgayGiao date NOT NULL,
    SoTienPhaiTra decimal(18,0) NOT NULL CHECK (SoTienPhaiTra >= 0),
    MaNVNhan varchar(20) NOT NULL,
    CONSTRAINT UQ_PhieuGiao_DDH_Dot UNIQUE (SoDDH, DotGiao),
    CONSTRAINT FK_PhieuGiao_DDH FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT FK_PhieuGiao_NV FOREIGN KEY (MaNVNhan) REFERENCES NhanVien(MaNV)
);

-- Bảng 9: Chi Tiết Phiếu Giao Hàng (QD04: Lưu đơn giá nhập thực tế)
CREATE TABLE ChiTietPhieuGiaoHang (
    SoPhieuGiao varchar(20) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongGiao int NOT NULL CHECK (SoLuongGiao > 0),
    DonGia decimal(18,0) NOT NULL CHECK (DonGia >= 0),
    PRIMARY KEY (SoPhieuGiao, MaNGK),
    CONSTRAINT FK_CTPG_PhieuGiao FOREIGN KEY (SoPhieuGiao) REFERENCES PhieuGiaoHang(SoPhieuGiao),
    CONSTRAINT FK_CTPG_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);

-- ----------------------------------------------------------------------------
-- 4. TẠO CÁC BẢNG BÁN HÀNG, HẸN GIAO & GHI NỢ
-- ----------------------------------------------------------------------------

-- Bảng 10: Hóa Đơn Bán Hàng (QD05, QD06: MaKH có thể null cho Khách vãng lai)
CREATE TABLE HoaDon (
    SoHoaDon varchar(20) NOT NULL PRIMARY KEY,
    NgayLap datetime NOT NULL DEFAULT GETDATE(),
    LoaiKhach nvarchar(20) NOT NULL CHECK (LoaiKhach IN (N'Khách quen', N'Khách vãng lai')),
    MaKH varchar(20) NULL,
    MaNV varchar(20) NOT NULL,
    TongTien decimal(18,0) NOT NULL CHECK (TongTien >= 0),
    TrangThaiGiao nvarchar(20) NOT NULL DEFAULT N'Đã giao đủ' CHECK (TrangThaiGiao IN (N'Đã giao đủ', N'Chờ giao hẹn')),
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng 11: Chi Tiết Hóa Đơn (QD04: Lưu đơn giá bán thực tế)
CREATE TABLE ChiTietHoaDon (
    SoHoaDon varchar(20) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuong int NOT NULL CHECK (SoLuong > 0),
    SoLuongDaGiao int NOT NULL DEFAULT 0 CHECK (SoLuongDaGiao >= 0),
    DonGia decimal(18,0) NOT NULL CHECK (DonGia >= 0),
    PRIMARY KEY (SoHoaDon, MaNGK),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (SoHoaDon) REFERENCES HoaDon(SoHoaDon),
    CONSTRAINT FK_CTHD_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);

-- Bảng 12: Phiếu Hẹn Giao (QD07, QD08: Hẹn giao nhiều đợt cho Khách quen khi thiếu kho)
CREATE TABLE PhieuHenGiao (
    MaPhieuHen varchar(20) NOT NULL PRIMARY KEY,
    SoHoaDon varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    NgayHenGiao date NOT NULL,
    MaNV varchar(20) NOT NULL,
    TrangThai nvarchar(20) NOT NULL DEFAULT N'Chờ giao' CHECK (TrangThai IN (N'Chờ giao', N'Đã giao')),
    NgayGiaoThucTe date NULL,
    CONSTRAINT FK_PhieuHen_HoaDon FOREIGN KEY (SoHoaDon) REFERENCES HoaDon(SoHoaDon),
    CONSTRAINT FK_PhieuHen_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng 13: Chi Tiết Phiếu Hẹn Giao
CREATE TABLE ChiTietPhieuHenGiao (
    MaPhieuHen varchar(20) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongHen int NOT NULL CHECK (SoLuongHen > 0),
    PRIMARY KEY (MaPhieuHen, MaNGK),
    CONSTRAINT FK_CTPH_PhieuHen FOREIGN KEY (MaPhieuHen) REFERENCES PhieuHenGiao(MaPhieuHen),
    CONSTRAINT FK_CTPH_NGK FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);

-- Bảng 14: Phiếu Ghi Nợ (QD09: Tối đa 1 phiếu nợ / 1 Hóa đơn của Khách quen)
CREATE TABLE PhieuGhiNo (
    MaPhieuNo varchar(20) NOT NULL PRIMARY KEY,
    SoHoaDon varchar(20) NOT NULL UNIQUE,
    MaKH varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    SoTienNo decimal(18,0) NOT NULL CHECK (SoTienNo > 0),
    NgayDuKienTra date NOT NULL,
    LyDoNo nvarchar(300) NULL,
    MaNV varchar(20) NOT NULL,
    CONSTRAINT FK_PhieuNo_HoaDon FOREIGN KEY (SoHoaDon) REFERENCES HoaDon(SoHoaDon),
    CONSTRAINT FK_PhieuNo_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_PhieuNo_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- ----------------------------------------------------------------------------
-- 5. CHÈN DỮ LIỆU MẪU (TEST DATA DÙNG CHO CÁC TEST CASE)
-- ----------------------------------------------------------------------------

-- Nhập Nhân viên mẫu
INSERT INTO NhanVien (MaNV, HoTen, SoDienThoai) VALUES 
('NV001', N'Nguyễn Văn A', '0901234567'),
('NV002', N'Trần Thị B', '0908765432');

-- Nhập Khách hàng mẫu
INSERT INTO KhachHang (MaKH, HoTen, DiaChi, SoDienThoai, LoaiKhach) VALUES 
('KH001', N'Lê Văn C', N'123 Lê Lợi, Q.1, TP.HCM', '0912345678', N'Khách quen'),
('KH002', N'Pham Thị D', N'456 Nguyễn Huệ, Q.1, TP.HCM', '0923456789', N'Khách quen');

-- Nhập Nhà cung ứng mẫu
INSERT INTO NhaCungUng (MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES 
('NCC01', N'Công ty Suntory PepsiCo', N'KCN Biên Hòa, Đồng Nai', '02513888888'),
('NCC02', N'Công ty Coca-Cola Việt Nam', N'Q. Thủ Đức, TP.HCM', '02838960000');

-- Nhập Nhãn hiệu mẫu
INSERT INTO NhanHieu (MaLoai, TenLoai, MaNCC) VALUES 
('L01', N'Pepsi', 'NCC01'),
('L02', N'Sting', 'NCC01'),
('L03', N'Coca Cola', 'NCC02');

-- Nhập Nước giải khát mẫu (Tồn kho sẵn phục vụ Test Case)
INSERT INTO NuocGiaiKhat (MaNGK, TenNGK, DonViTinh, MaLoai, SoLuongTon) VALUES 
('NGK01', N'Pepsi Lon 330ml', N'Lon', 'L01', 10),
('NGK02', N'Sting Dâu Chai 330ml', N'Chai', 'L02', 5),
('NGK03', N'Coca Cola Chai 1.5L', N'Chai', 'L03', 20);

GO