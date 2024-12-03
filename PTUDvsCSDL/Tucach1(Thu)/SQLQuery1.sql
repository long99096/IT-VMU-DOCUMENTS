create database tucach1
use tucach1
create table Khoa(
	MaKhoa int identity primary key,
	TenKhoa nvarchar(30) not null unique,
	MaTruongKhoa int
)

create table ChuyenNganh(
	MaChuyenNganh int identity unique,
	TenChuyenNganh nvarchar(30) not null unique,
	MaGiangVienPhuTrach int 
)

create table Lop(
	TenLop char(7) primary key,
	MaCVHT int not null,
	NamBatDau int not null,
	check(NamBatDau >= 0)
)

create table GiangVien(
	MaGiangVien int identity primary key,
	HoTen nvarchar(30) not null,
	NgaySinh date not null,
	MaKhoa int not null
)

create table SinhVien(
	MaSinhVien int identity primary key,
	HoTen nvarchar(30) not null,
	NgaySinh date not null,
	TenLop char(7) not null references Lop(TenLop)
)

alter table Khoa add constraint fkkhoa foreign key (MaTruongKhoa) references GiangVien(MaGiangVien)
alter table ChuyenNganh add constraint fkchuyennganh foreign key (MaGiangVienPhuTrach) references GiangVien(MaGiangVien) 
alter table Lop add constraint fklop foreign key (MaCVHT) references GiangVien(MaGiangVien)
alter table GiangVien add constraint fkgiangvien foreign key (MaKhoa) references Khoa(MaKhoa)
alter table SinhVien add constraint fksinhvien foreign key (TenLop) references Lop(TenLop)