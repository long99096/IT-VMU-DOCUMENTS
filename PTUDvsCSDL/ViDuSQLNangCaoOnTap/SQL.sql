CREATE DATABASE ViDuSQLNangCaoOnTap
USE ViDuSQLNangCaoOnTap
CREATE TABLE ChucVu (
    MaChucVu INT IDENTITY PRIMARY KEY,
    TenChucVu NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE PhongBan (
    MaPhongBan INT IDENTITY PRIMARY KEY,
    TenPhongBan NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY PRIMARY KEY,
    HoTen NVARCHAR(30) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh BIT NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    MaChucVu INT NOT NULL REFERENCES ChucVu(MaChucVu),
    MaPhongBan INT NOT NULL REFERENCES PhongBan(MaPhongBan)
)

create view vNhanVien
as
select MaNhanVien,HoTen,NgaySinh,case GioiTinh when 1 then 'Nam' when 0 then 'Nu' end GioiTinh,DiaChi,TenChucVu,TenPhongBan
from NhanVien
inner join ChucVu on NhanVien.MaChucVu = ChucVu.MaChucVu
inner join PhongBan on NhanVien.MaPhongBan = PhongBan.MaPhongBan

CREATE PROCEDURE ThemNhanVien
    @HoTen NVARCHAR(30),@NgaySinh DATE,@GioiTinh BIT,@DiaChi NVARCHAR(100),
    @MaChucVu INT,@MaPhongBan INT
AS BEGIN
    DECLARE @Dem INT
    DECLARE @Loi NVARCHAR(300)
    SET @Loi = ''
    SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu=@MaChucVu)
    IF @Dem = 0
        SET @Loi = N'Mã ch?c v? không t?n t?i. '
    SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan=@MaPhongBan)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã phòng ban không t?n t?i. '
    IF @Loi <> ''
        RAISERROR(@Loi,16,1)
    ELSE
        INSERT NhanVien VALUES
        (@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan)
END

CREATE PROCEDURE SuaNhanVien
    @MaNhanVien INT,@HoTen NVARCHAR(30),@NgaySinh DATE,@GioiTinh BIT,
    @DiaChi NVARCHAR(100),@MaChucVu INT,@MaPhongBan INT
AS BEGIN
    DECLARE @Dem INT
    DECLARE @Loi NVARCHAR(300)
    SET @Loi = ''
    SET @Dem = (SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien=@MaNhanVien)
    IF @Dem = 0
        SET @Loi = N'Mã nhân viên không t?n t?i. '
    SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu=@MaChucVu)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã ch?c v? không t?n t?i. '
    SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan=@MaPhongBan)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã phòng ban không t?n t?i. '
    IF @Loi <> ''
        RAISERROR(@Loi,16,1)
    ELSE
        UPDATE NhanVien
            SET HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,
            DiaChi=@DiaChi,MaChucVu=@MaChucVu,MaPhongBan=@MaPhongBan
            WHERE MaNhanVien=@MaNhanVien
END

CREATE PROCEDURE XoaNhanVien @MaNhanVien INT
AS BEGIN
    DECLARE @Dem INT
    SET @Dem = (SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien=@MaNhanVien)
    IF @Dem > 0
        DELETE NhanVien WHERE MaNhanVien = @MaNhanVien
    ELSE
        RAISERROR(N'Mã nhân viên không t?n t?i',16,1)
END

CREATE FUNCTION TimKiemNhanVien
    (@MaNhanVien INT,@HoTen NVARCHAR(30),@NgaySinh DATE,@GioiTinh BIT,
    @DiaChi NVARCHAR(100),@MaChucVu INT,@MaPhongBan INT)
RETURNS TABLE
AS RETURN
(SELECT MaNhanVien,HoTen,NgaySinh,
    CASE GioiTinh WHEN 1 THEN 'Nam' WHEN 0 THEN N'N?' END GioiTinh,
    DiaChi,TenChucVu,TenPhongBan
FROM NhanVien
INNER JOIN ChucVu ON NhanVien.MaChucVu=ChucVu.MaChucVu
INNER JOIN PhongBan ON NhanVien.MaPhongBan=PhongBan.MaPhongBan
WHERE (MaNhanVien = @MaNhanVien OR @MaNhanVien IS NULL)
AND (HoTen LIKE '%' + @HoTen + '%')
AND (GioiTinh=@GioiTinh OR @GioiTinh IS NULL)
AND (NgaySinh=@NgaySinh OR @NgaySinh IS NULL)
AND (DiaChi LIKE '%' + @DiaChi + '%')
AND (NhanVien.MaChucVu=@MaChucVu OR @MaChucVu IS NULL)
AND (NhanVien.MaPhongBan=@MaPhongBan OR @MaPhongBan IS NULL))