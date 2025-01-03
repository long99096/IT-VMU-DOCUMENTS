create database BuiHoangLong_99096_KT3

use BuiHoangLong_99096_KT3
create table ChucVu_0(
	MaChucVu varchar(3) primary key,
	TenChucVu nvarchar(30) not null unique,
	MucLuong float not null,
	PhuCap float not null,
	check(MucLuong > 0 and PhuCap > 0)
)

create table NhanVien_9(
	MaNhanVien varchar(5) primary key,
	HoTen nvarchar(30) not null,
	MaChucVu varchar(3) not null references ChucVu_0(MaChucVu),
	NgayVaoLam date not null
)

create table KhoHang_6(
	MaKhoHang varchar(3) primary key,
	TenKhoHang nvarchar(30) not null unique,
	DiaChi nvarchar(100) not null,
	MaNhanVienPhuTrach varchar(5) not null references NhanVien_9(MaNhanVien)
)

create view vKhoHang
as
select MaKhoHang,TenKhoHang,DiaChi, HoTen
from KhoHang_6
inner join NhanVien_9 on NhanVien_9.MaNhanVien = KhoHang_6.MaNhanVienPhuTrach

select * from vKhoHang

alter procedure XoaChucVu 
@MaChucVu varchar(3)
as begin
    declare @Dem int
    set @Dem = (select COUNT(*) from ChucVu_0 where MaChucVu=@MaChucVu)
    if @Dem > 0
        delete ChucVu_0 where MaChucVu=@MaChucVu
    else
        raiserror(N'Ma chuc vu khong ton tai',16,1)
		delete ChucVu_0 where MaChucVu=@MaChucVu
end

create function TimKiemNhanVien(
	@chuoi nvarchar(50)
)
returns table
as return
(
	select MaNhanVien, HoTen, NhanVien_9.MaChucVu, TenChucVu, NgayVaoLam from NhanVien_9
	inner join ChucVu_0
	on NhanVien_9.MaChucVu = ChucVu_0.MaChucVu
	where MaNhanVien like '%' + @chuoi + '%'
	or HoTen like '%' + @chuoi + '%'
	or TenChucVu like '%' + @chuoi + '%'
)

select * from dbo.TimKiemNhanVien('GD')