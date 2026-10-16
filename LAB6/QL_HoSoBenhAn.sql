CREATE DATABASE QL_HoSoBenhAn;
GO
USE QL_HoSoBenhAn;
GO

-- 1. Bảng Bệnh nhân
CREATE TABLE BenhNhan (
    MaBN VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    NgayDongPhi DATE
);

-- 2. Bảng Hồ sơ bệnh án (Quan hệ 1-1 với Bệnh nhân -> UNIQUE MaBN)
CREATE TABLE HoSoBenhAn (
    MaHoSo VARCHAR(20) PRIMARY KEY,
    MaBN VARCHAR(20) UNIQUE NOT NULL, -- Ràng buộc UNIQUE
    NgayLap DATE,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN)
);

-- 3. Bảng Phiếu khám (1 hồ sơ có nhiều phiếu khám)
CREATE TABLE PhieuKham (
    MaPhieu VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    BacSi NVARCHAR(100),
    TrieuChung NVARCHAR(500),
    FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo)
);

-- 4. Bảng Xét nghiệm (Nhiều xét nghiệm thuộc 1 phiếu khám)
CREATE TABLE XetNghiem (
    MaXN VARCHAR(20) PRIMARY KEY,
    MaPhieu VARCHAR(20),
    TenXN NVARCHAR(255),
    KetQua NVARCHAR(MAX),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuKham(MaPhieu)
);

-- 5. Bảng Toa thuốc (1 phiếu khám có tối đa 1 toa thuốc -> UNIQUE MaPhieu)
CREATE TABLE ToaThuoc (
    MaToa VARCHAR(20) PRIMARY KEY,
    MaPhieu VARCHAR(20) UNIQUE NOT NULL,
    NgayKeToa DATE,
    FOREIGN KEY (MaPhieu) REFERENCES PhieuKham(MaPhieu)
);

-- 6. Bảng Lịch hẹn
CREATE TABLE LichHen (
    MaLich VARCHAR(20) PRIMARY KEY,
    MaBN VARCHAR(20),
    NgayGioHen DATETIME,
    FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN)
);