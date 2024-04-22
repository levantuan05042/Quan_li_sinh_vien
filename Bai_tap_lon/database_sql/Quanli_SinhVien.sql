USE master;
GO
CREATE DATABASE QL_SinhVien;
GO
USE QL_SinhVien;
GO
CREATE TABLE dbo.ChinhSach (
    ma_chinhsach nvarchar(10) NOT NULL,
    ten_chinhsach nvarchar(50),
    chedo_chinhsach nvarchar(50),
    PRIMARY KEY CLUSTERED (ma_chinhsach ASC)
);
GO
CREATE TABLE dbo.Diem (
    id nvarchar(10) NOT NULL,
    ma_sinhvien nvarchar(10),
    ma_monhoc nvarchar(10),
    diem float,
    PRIMARY KEY CLUSTERED (id ASC)
);
CREATE TABLE dbo.GiaoVien (
    ma_giaovien nvarchar(10) NOT NULL,
    ten_giaovien nvarchar(50),
    gioitinh_giaovien nvarchar(6),
    ngaysinh_giaovien date,
    sdt_giaovien text,
    diachi_giaovien nvarchar(50),
    PRIMARY KEY CLUSTERED (ma_giaovien ASC)
);
GO
CREATE TABLE dbo.Khoa (
    ma_khoa nvarchar(10) NOT NULL,
    ten_khoa nvarchar(30),
    PRIMARY KEY CLUSTERED (ma_khoa ASC)
);
GO
CREATE TABLE dbo.Lop (
    ma_lop nvarchar(10) NOT NULL,
    ten_lop nvarchar(30),
    ma_khoa nvarchar(10),
    PRIMARY KEY CLUSTERED (ma_lop ASC)
);
GO

CREATE TABLE dbo.MonHoc (
    ma_monhoc nvarchar(10) NOT NULL,
    ten_monhoc nvarchar(50),
    sotiet_monhoc int,
    ma_giaovien nvarchar(10),
    PRIMARY KEY CLUSTERED (ma_monhoc ASC)
);
GO
CREATE TABLE dbo.SinhVien (
    ma_sinhvien nvarchar(10) NOT NULL,
    ten_sinhvien nvarchar(50),
    gioitinh_sinhvien nvarchar(6),
    ngaysinh_sinhvien date,
    sdt_sinhvien text,
    diachi_sinhvien nvarchar(50),
    ma_chinhsach nvarchar(10),
    ma_lop nvarchar(10),
    PRIMARY KEY CLUSTERED (ma_sinhvien ASC)
);
GO
CREATE TABLE TaiKhoan (
    username NVARCHAR(50) PRIMARY KEY,
    fullname NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    phone_number TEXT NOT NULL,
    mode NVARCHAR(50) CHECK (mode IN (N'Admin',N'User', N'Trưởng Khoa', N'Giáo Viên')) NOT NULL,
    state BIT
);
GO
ALTER TABLE dbo.Diem WITH CHECK ADD CONSTRAINT FK_Diem_MonHoc FOREIGN KEY(ma_monhoc)
REFERENCES dbo.MonHoc (ma_monhoc);
GO
ALTER TABLE dbo.Diem CHECK CONSTRAINT FK_Diem_MonHoc;
GO
ALTER TABLE dbo.Diem WITH CHECK ADD CONSTRAINT FK_Diem_SinhVien FOREIGN KEY(ma_sinhvien)
REFERENCES dbo.SinhVien (ma_sinhvien);
GO
ALTER TABLE dbo.Diem CHECK CONSTRAINT FK_Diem_SinhVien;
GO
ALTER TABLE dbo.Lop WITH CHECK ADD CONSTRAINT FK_Lop_Khoa FOREIGN KEY(ma_khoa)
REFERENCES dbo.Khoa (ma_khoa);
GO
ALTER TABLE dbo.Lop CHECK CONSTRAINT FK_Lop_Khoa;
GO
ALTER TABLE dbo.MonHoc WITH CHECK ADD CONSTRAINT FK_MonHoc_GiaoVien FOREIGN KEY(ma_giaovien)
REFERENCES dbo.GiaoVien (ma_giaovien);
GO
ALTER TABLE dbo.MonHoc CHECK CONSTRAINT FK_MonHoc_GiaoVien;
GO
ALTER TABLE dbo.SinhVien WITH CHECK ADD CONSTRAINT FK_SinhVien_ChinhSach FOREIGN KEY(ma_chinhsach)
REFERENCES dbo.ChinhSach (ma_chinhsach);
GO
ALTER TABLE dbo.SinhVien CHECK CONSTRAINT FK_SinhVien_ChinhSach;
GO
ALTER TABLE dbo.SinhVien WITH CHECK ADD CONSTRAINT FK_SinhVien_Lop FOREIGN KEY(ma_lop)
REFERENCES dbo.Lop (ma_lop);
GO
ALTER TABLE dbo.SinhVien CHECK CONSTRAINT FK_SinhVien_Lop;
GO

-- Inserting data into TaiKhoan table
INSERT INTO TaiKhoan (username, fullname, password, phone_number, mode, state)
VALUES ('admin', 'Admin', 'admin123', '0123456789', N'Admin', 1);
USE master;
GO
ALTER DATABASE QL_SinhVien SET READ_WRITE;
GO