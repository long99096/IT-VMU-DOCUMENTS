-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1:3307
-- Thời gian đã tạo: Th1 08, 2023 lúc 02:57 PM
-- Phiên bản máy phục vụ: 10.4.25-MariaDB
-- Phiên bản PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `nhansu`
--

-- --------------------------------------------------------

--
-- Cấu trúc đóng vai cho view `hienthi`
-- (See below for the actual view)
--
CREATE TABLE `hienthi` (
`IDNS` varchar(32)
,`tenPB` varchar(255)
,`trangthai` int(11)
,`tenTD` varchar(255)
,`hovaten` varchar(255)
,`dienthoai` varchar(10)
,`email` varchar(255)
);

-- --------------------------------------------------------

--
-- Cấu trúc đóng vai cho view `hienthi2`
-- (See below for the actual view)
--
CREATE TABLE `hienthi2` (
`TenNS` varchar(255)
,`IDNS` varchar(32)
,`IDTN` int(11)
,`ten` varchar(255)
,`quanhe` varchar(50)
,`dienthoai` varchar(10)
);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhansu`
--

CREATE TABLE `nhansu` (
  `id` varchar(32) NOT NULL,
  `phongban_id` int(11) NOT NULL,
  `trangthai` int(11) NOT NULL,
  `trinhdo_id` int(11) NOT NULL,
  `hovaten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhansu`
--

INSERT INTO `nhansu` (`id`, `phongban_id`, `trangthai`, `trinhdo_id`, `hovaten`, `dienthoai`, `email`) VALUES
('1', 1, 1, 2, 'Trinh văn A', '1223', 'Aemail'),
('2', 2, 1, 1, 'Trinh văn B', '1223', 'Bemail');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phongban`
--

CREATE TABLE `phongban` (
  `id` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `diachi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `phongban`
--

INSERT INTO `phongban` (`id`, `ten`, `dienthoai`, `diachi`) VALUES
(1, 'phòng tài chính', '123', 'hải phòng'),
(2, 'phòng nhân sự', '123', 'hà nội'),
(3, 'phòng kinh doanh', '123', 'hà nội');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `quatrinhdaotao`
--

CREATE TABLE `quatrinhdaotao` (
  `id` varchar(32) NOT NULL,
  `nhansu_id` varchar(32) NOT NULL,
  `tungay` datetime NOT NULL,
  `denngay` datetime NOT NULL,
  `loaihinhdaotao` varchar(100) NOT NULL,
  `bangcap` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thannhan`
--

CREATE TABLE `thannhan` (
  `id` int(11) NOT NULL,
  `nhansu_id` varchar(32) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `quanhe` varchar(50) NOT NULL,
  `dienthoai` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thannhan`
--

INSERT INTO `thannhan` (`id`, `nhansu_id`, `ten`, `quanhe`, `dienthoai`) VALUES
(1, '1', 'Trinh vănC', '1', '1'),
(2, '2', 'Trinh vănD', '1', '1'),
(3, '1', 'trinh', 'anh', '333'),
(4, '1', 'tien', 'em', '322'),
(5, '1', 'loc', 'bố', '4444'),
(6, '1', 'tr', 'tr', '5'),
(7, '1', 'y', 'y', '6'),
(8, '2', 'g', 'g', '5'),
(9, '2', 'g', 'h', '7'),
(10, '2', 'd', 'd', '5'),
(11, '2', 'hh', 'hh', '6');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `trinhdohocvan`
--

CREATE TABLE `trinhdohocvan` (
  `id` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `mota` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `trinhdohocvan`
--

INSERT INTO `trinhdohocvan` (`id`, `ten`, `mota`) VALUES
(1, 'cao học', 'học cao'),
(2, 'đại học', 'học đại'),
(3, 'cấp 3', 'cấp 3');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `tendaydu` varchar(255) NOT NULL,
  `quyenhan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc cho view `hienthi`
--
DROP TABLE IF EXISTS `hienthi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `hienthi`  AS SELECT `id` AS `IDNS`, `phongban`.`ten` AS `tenPB`, `trangthai` AS `trangthai`, `trinhdohocvan`.`ten` AS `tenTD`, `hovaten` AS `hovaten`, `dienthoai` AS `dienthoai`, `email` AS `email` FROM ((`nhansu` join `phongban`) join `trinhdohocvan`) WHERE `phongban_id` = `phongban`.`id` AND `trinhdo_id` = `trinhdohocvan`.`id``id`  ;

-- --------------------------------------------------------

--
-- Cấu trúc cho view `hienthi2`
--
DROP TABLE IF EXISTS `hienthi2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `hienthi2`  AS SELECT `hovaten` AS `TenNS`, `id` AS `IDNS`, `thannhan`.`id` AS `IDTN`, `thannhan`.`ten` AS `ten`, `thannhan`.`quanhe` AS `quanhe`, `thannhan`.`dienthoai` AS `dienthoai` FROM (`thannhan` join `nhansu`) WHERE `id` = `thannhan`.`nhansu_id``nhansu_id`  ;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `nhansu`
--
ALTER TABLE `nhansu`
  ADD PRIMARY KEY (`id`),
  ADD KEY `phongban_id` (`phongban_id`),
  ADD KEY `trinhdo_id` (`trinhdo_id`);

--
-- Chỉ mục cho bảng `phongban`
--
ALTER TABLE `phongban`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `quatrinhdaotao`
--
ALTER TABLE `quatrinhdaotao`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nhansu_id` (`nhansu_id`);

--
-- Chỉ mục cho bảng `thannhan`
--
ALTER TABLE `thannhan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nhansu_id` (`nhansu_id`);

--
-- Chỉ mục cho bảng `trinhdohocvan`
--
ALTER TABLE `trinhdohocvan`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `phongban`
--
ALTER TABLE `phongban`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `thannhan`
--
ALTER TABLE `thannhan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT cho bảng `trinhdohocvan`
--
ALTER TABLE `trinhdohocvan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `nhansu`
--
ALTER TABLE `nhansu`
  ADD CONSTRAINT `nhansu_ibfk_1` FOREIGN KEY (`phongban_id`) REFERENCES `phongban` (`id`),
  ADD CONSTRAINT `nhansu_ibfk_2` FOREIGN KEY (`trinhdo_id`) REFERENCES `trinhdohocvan` (`id`);

--
-- Các ràng buộc cho bảng `quatrinhdaotao`
--
ALTER TABLE `quatrinhdaotao`
  ADD CONSTRAINT `quatrinhdaotao_ibfk_1` FOREIGN KEY (`nhansu_id`) REFERENCES `nhansu` (`id`);

--
-- Các ràng buộc cho bảng `thannhan`
--
ALTER TABLE `thannhan`
  ADD CONSTRAINT `thannhan_ibfk_1` FOREIGN KEY (`nhansu_id`) REFERENCES `nhansu` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
