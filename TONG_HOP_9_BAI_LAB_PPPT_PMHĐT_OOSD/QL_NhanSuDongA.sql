-- 1. TẠO CƠ SỞ DỮ LIỆU
CREATE DATABASE QL_NhanSuDongA;
GO
USE QL_NhanSuDongA;
GO

-- 2. TẠO CÁC BẢNG (TABLES)
-- Bảng Phòng Ban
CREATE TABLE PhongBan (
    MaPB VARCHAR(20) PRIMARY KEY,
    TenPB NVARCHAR(100) NOT NULL
);

-- Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV VARCHAR(20) PRIMARY KEY,
    MaPB VARCHAR(20) FOREIGN KEY REFERENCES PhongBan(MaPB),
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    SoDienThoai VARCHAR(20)
);

-- Bảng Hợp Đồng Lao Động
CREATE TABLE HopDongLaoDong (
    MaHD VARCHAR(20) PRIMARY KEY,
    MaNV VARCHAR(20) FOREIGN KEY REFERENCES NhanVien(MaNV),
    NgayKy DATE NOT NULL,
    LoaiHD NVARCHAR(50) CHECK (LoaiHD IN (N'Dài hạn', N'Ngắn hạn'))
);

-- Bảng Hồ Sơ Bảo Hiểm (Áp dụng BR04: Chỉ hợp đồng dài hạn mới có)
CREATE TABLE HoSoBaoHiem (
    MaHSBH VARCHAR(20) PRIMARY KEY,
    MaHD VARCHAR(20) UNIQUE FOREIGN KEY REFERENCES HopDongLaoDong(MaHD),
    MucDongBHXH DECIMAL(18,2),
    MucDongBHYT DECIMAL(18,2)
);

-- Bảng Quyết Định Khen Thưởng / Kỷ Luật
CREATE TABLE QDKhenThuong_KyLuat (
    MaQD VARCHAR(20) PRIMARY KEY,
    MaNV VARCHAR(20) FOREIGN KEY REFERENCES NhanVien(MaNV),
    LoaiQD NVARCHAR(50),
    LyDo NVARCHAR(255),
    SoTien DECIMAL(18,2) CHECK (SoTien > 0),
    TrangThai NVARCHAR(50)
);

-- Bảng Phiếu Thu / Chi (Áp dụng BR10: Khen thưởng bắt buộc sinh phiếu chi)
CREATE TABLE PhieuThu_Chi (
    SoPhieu VARCHAR(20) PRIMARY KEY,
    MaQD VARCHAR(20) UNIQUE FOREIGN KEY REFERENCES QDKhenThuong_KyLuat(MaQD),
    LoaiPhieu NVARCHAR(20),
    NgayLap DATETIME DEFAULT GETDATE(),
    SoTien DECIMAL(18,2)
);
GO

-- 3. TẠO DỮ LIỆU MẪU (DÙNG ĐỂ TEST GIAO DIỆN & TÌM KIẾM)
INSERT INTO PhongBan VALUES ('PB01', N'Phòng Kỹ Thuật');
INSERT INTO PhongBan VALUES ('PB02', N'Phòng Nhân Sự');

INSERT INTO NhanVien VALUES ('NV01', 'PB02', N'Nguyễn Văn A', '1998-05-12', '0901234567');
INSERT INTO NhanVien VALUES ('NV02', 'PB01', N'Trần Thị B', '1995-08-20', '0912345678');

INSERT INTO HopDongLaoDong VALUES ('HD01', 'NV01', '2025-01-01', N'Dài hạn');
INSERT INTO HopDongLaoDong VALUES ('HD02', 'NV02', '2026-02-10', N'Ngắn hạn');

INSERT INTO HoSoBaoHiem VALUES ('HS01', 'HD01', 500000, 200000);
GO

-- 4. CÁC CÂU LỆNH TÌM KIẾM (SELECT) PHỤC VỤ CHO GIAO DIỆN C#
-- Tìm kiếm nhân viên theo Mã hoặc Họ Tên (Dùng cho ô tìm kiếm trên Form)
CREATE PROCEDURE sp_TimKiemNhanVien
    @TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT nv.MaNV, nv.HoTen, pb.TenPB, nv.NgaySinh, nv.SoDienThoai
    FROM NhanVien nv
    JOIN PhongBan pb ON nv.MaPB = pb.MaPB
    WHERE nv.MaNV LIKE '%' + @TuKhoa + '%' OR nv.HoTen LIKE '%' + @TuKhoa + '%';
END;
GO

-- Truy vấn xem danh sách khen thưởng kèm phiếu chi tương ứng (Test BR10)
SELECT qd.MaQD, nv.HoTen, qd.LyDo, qd.SoTien, pc.SoPhieu, pc.LoaiPhieu, pc.NgayLap
FROM QDKhenThuong_KyLuat qd
JOIN NhanVien nv ON qd.MaNV = nv.MaNV
LEFT JOIN PhieuThu_Chi pc ON qd.MaQD = pc.MaQD;