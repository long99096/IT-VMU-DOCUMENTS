-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 27, 2022 lúc 02:34 PM
-- Phiên bản máy phục vụ: 10.4.22-MariaDB
-- Phiên bản PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `ontap`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietvandon`
--

CREATE TABLE `chitietvandon` (
  `ID` varchar(32) NOT NULL,
  `vandon` varchar(32) NOT NULL,
  `hanghoa_ID` int(11) NOT NULL,
  `soluong` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `chitietvandon`
--

INSERT INTO `chitietvandon` (`ID`, `vandon`, `hanghoa_ID`, `soluong`) VALUES
('01', '01', 2, 1),
('02', '02', 3, 2),
('03', '03', 2, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hanghoa`
--

CREATE TABLE `hanghoa` (
  `ID` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `hangsx_ID` int(11) NOT NULL,
  `quycach` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `hanghoa`
--

INSERT INTO `hanghoa` (`ID`, `ten`, `hangsx_ID`, `quycach`) VALUES
(1, 'Iphone 14 promax', 2, 'Đóng hộp 1 chiếc'),
(2, 'iPhone 12 Promax ', 2, 'Đóng hộp 1 chiếc '),
(3, 'Samsung Promax', 1, '1 hộp 2 chiếc');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hangsanxuat`
--

CREATE TABLE `hangsanxuat` (
  `ID` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `mota` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `hangsanxuat`
--

INSERT INTO `hangsanxuat` (`ID`, `ten`, `mota`) VALUES
(1, 'Samsung', 'Tập đoàn điện tử Hàn Quốc'),
(2, 'Apple', 'Tập đoàn điện tử Mỹ');

-- --------------------------------------------------------

--
-- Cấu trúc đóng vai cho view `hienthi`
-- (See below for the actual view)
--
CREATE TABLE `hienthi` (
`ID` varchar(32)
,`IDCT` varchar(32)
,`hoten` varchar(255)
,`nguoinhan` varchar(255)
,`ten` varchar(255)
,`soluong` int(11)
);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhanvien`
--

CREATE TABLE `nhanvien` (
  `ID` int(11) NOT NULL,
  `hoten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `email` varchar(255) NOT NULL,
  `diachi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhanvien`
--

INSERT INTO `nhanvien` (`ID`, `hoten`, `dienthoai`, `email`, `diachi`) VALUES
(1, 'Bùi Thị Hồng Nhung', '0336849813', 'nhung@gmail.com', 'Lê Chân - Hải Phòng'),
(2, 'Trịnh Tiến Lộc', '0987674523', 'loc@gmail.com', 'An Lão - Hải Phòng'),
(3, 'Vũ Khánh Linh', '0123456789', 'linh@gmail.com', 'Hồng Bàng - Hải Phòng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `tendaydu` varchar(255) NOT NULL,
  `quyenhan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `user`
--

INSERT INTO `user` (`ID`, `username`, `matkhau`, `tendaydu`, `quyenhan`) VALUES
(1, 'student', '123456', 'Bùi Thị Hồng Nhung', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `vandon`
--

CREATE TABLE `vandon` (
  `ID` varchar(32) NOT NULL,
  `nhanvien_ID` int(11) NOT NULL,
  `trangthai` int(11) NOT NULL,
  `nguoinhan` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `diachi` text NOT NULL,
  `ngaygiaohang` datetime NOT NULL,
  `ghichu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `vandon`
--

INSERT INTO `vandon` (`ID`, `nhanvien_ID`, `trangthai`, `nguoinhan`, `dienthoai`, `diachi`, `ngaygiaohang`, `ghichu`) VALUES
('01', 1, 0, 'Vũ Tiến Huynh', '033456789', 'Thủy Nguyên - Hải Phòng', '2022-12-31 17:43:11', ''),
('02', 3, 1, 'Lê Minh Hoàng', '0945748245', 'Kiến An - Hải Phòng', '2021-01-08 23:02:32', ''),
('03', 2, 0, 'Nguyễn Việt Hùng', '0909111222', 'Kiến An - Hải Phòng', '2022-12-27 11:51:28', '');

-- --------------------------------------------------------

--
-- Cấu trúc cho view `hienthi`
--
DROP TABLE IF EXISTS `hienthi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `hienthi`  AS SELECT `vandon`.`ID` AS `ID`, `chitietvandon`.`ID` AS `IDCT`, `nhanvien`.`hoten` AS `hoten`, `vandon`.`nguoinhan` AS `nguoinhan`, `hanghoa`.`ten` AS `ten`, `chitietvandon`.`soluong` AS `soluong` FROM (((`vandon` join `nhanvien`) join `hanghoa`) join `chitietvandon`) WHERE `vandon`.`ID` = `chitietvandon`.`vandon` AND `hanghoa`.`ID` = `chitietvandon`.`hanghoa_ID` AND `nhanvien`.`ID` = `vandon`.`nhanvien_ID` ;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `chitietvandon`
--
ALTER TABLE `chitietvandon`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `hanghoa_ID` (`hanghoa_ID`),
  ADD KEY `vandon` (`vandon`);

--
-- Chỉ mục cho bảng `hanghoa`
--
ALTER TABLE `hanghoa`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `hangsx_ID` (`hangsx_ID`);

--
-- Chỉ mục cho bảng `hangsanxuat`
--
ALTER TABLE `hangsanxuat`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `vandon`
--
ALTER TABLE `vandon`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `nhanvien_ID` (`nhanvien_ID`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chitietvandon`
--
ALTER TABLE `chitietvandon`
  ADD CONSTRAINT `chitietvandon_ibfk_1` FOREIGN KEY (`hanghoa_ID`) REFERENCES `hanghoa` (`ID`),
  ADD CONSTRAINT `chitietvandon_ibfk_2` FOREIGN KEY (`vandon`) REFERENCES `vandon` (`ID`);

--
-- Các ràng buộc cho bảng `hanghoa`
--
ALTER TABLE `hanghoa`
  ADD CONSTRAINT `hanghoa_ibfk_1` FOREIGN KEY (`hangsx_ID`) REFERENCES `hangsanxuat` (`ID`);

--
-- Các ràng buộc cho bảng `vandon`
--
ALTER TABLE `vandon`
  ADD CONSTRAINT `vandon_ibfk_1` FOREIGN KEY (`nhanvien_ID`) REFERENCES `nhanvien` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
