CREATE DATABASE eSHOPPING_Lab4;
GO
USE eSHOPPING_Lab4;
GO

-- 1. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    SoGiayTo VARCHAR(20),
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(15),
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(100) NOT NULL,
    Email VARCHAR(100)
);

-- 2. Bảng Đơn Hàng
CREATE TABLE DonHang (
    MaDH INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    ThoiDiemDat DATETIME DEFAULT GETDATE(),
    HoTenNguoiNhan NVARCHAR(100) NOT NULL,
    DiaChiNhan NVARCHAR(255) NOT NULL,
    DienThoaiNhan VARCHAR(15) NOT NULL,
    HinhThucGiao VARCHAR(50) NOT NULL, -- THUONG / NHANH / TRONG_NGAY
    TienHang DECIMAL(18,2) NOT NULL,
    PhiGiao DECIMAL(18,2) NOT NULL,
    TongThanhToan DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chờ thanh toán'
);

-- 3. Bảng Chi Tiết Đơn Hàng (Quan hệ Composition với DonHang)
CREATE TABLE ChiTietDonHang (
    MaDH INT FOREIGN KEY REFERENCES DonHang(MaDH) ON DELETE CASCADE,
    MaSP VARCHAR(50) NOT NULL, -- Lấy từ Hệ thống quản lý sản phẩm ngoài
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    ThanhTien DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaDH, MaSP)
);

-- 4. Bảng Thanh Toán (Gắn liền BR06)
CREATE TABLE ThanhToan (
    MaGiaoDich VARCHAR(50) PRIMARY KEY,
    MaDH INT FOREIGN KEY REFERENCES DonHang(MaDH),
    LoaiThe VARCHAR(50) NOT NULL, -- Visa / Master
    SoThe VARCHAR(20) NOT NULL,
    NgayGiaoDich DATETIME DEFAULT GETDATE(),
    KetQua NVARCHAR(50) NOT NULL -- ThanhCong / ThatBai
);

-- 5. Bảng Email Xác Nhận
CREATE TABLE EmailXacNhan (
    MaEmail INT IDENTITY(1,1) PRIMARY KEY,
    MaDH INT FOREIGN KEY REFERENCES DonHang(MaDH),
    NoiDung NVARCHAR(MAX) NOT NULL,
    ThoiGianGui DATETIME DEFAULT GETDATE()
);

USE eSHOPPING_Lab4;
GO

-- Bật quyền cho phép chèn ID thủ công vào bảng KhachHang
SET IDENTITY_INSERT KhachHang ON;
GO

INSERT INTO KhachHang (MaKH, HoTen, DienThoai, DiaChi, TenDangNhap, MatKhau) 
VALUES (1, N'Nguyễn Trang', '0961728619', N'80 Xô Viết Nghệ Tĩnh', 'trang123', '123456');
GO

-- Tắt quyền đi để trả lại trạng thái tự động tăng bình thường
SET IDENTITY_INSERT KhachHang OFF;
GO

-- xem donhang
SELECT * FROM DonHang;