-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 09, 2023 at 03:50 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `benhvien`
--

-- --------------------------------------------------------

--
-- Table structure for table `benhnhan`
--

CREATE TABLE `benhnhan` (
  `ID` varchar(32) NOT NULL,
  `trangthai` int(11) NOT NULL,
  `hovaten` varchar(255) NOT NULL,
  `ngaysinh` datetime NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `mota` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `benhnhan`
--

INSERT INTO `benhnhan` (`ID`, `trangthai`, `hovaten`, `ngaysinh`, `dienthoai`, `mota`) VALUES
('23', 123, 'HUYNH', '2023-01-05 11:49:16', '1111111111', 'KHON'),
('24', 122, 'Hoàng', '2023-01-05 11:49:47', '1222222222', 'aaaa');

-- --------------------------------------------------------

--
-- Table structure for table `dieutri`
--

CREATE TABLE `dieutri` (
  `ID` int(11) NOT NULL,
  `nhanvien_ID` int(11) NOT NULL,
  `loaibenh_ID` int(11) NOT NULL,
  `benhnhan` varchar(32) NOT NULL,
  `ngaybatdau` datetime NOT NULL,
  `ngayketthuc` datetime NOT NULL,
  `nhanxet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dieutri`
--

INSERT INTO `dieutri` (`ID`, `nhanvien_ID`, `loaibenh_ID`, `benhnhan`, `ngaybatdau`, `ngayketthuc`, `nhanxet`) VALUES
(1, 13, 34, '23', '2023-01-05 11:51:16', '2023-01-05 11:51:16', 1222),
(2, 12, 35, '23', '2023-01-05 11:51:40', '2023-01-05 11:51:40', 44),
(4, 13, 34, '23', '2023-01-25 09:47:00', '2023-01-25 09:47:00', 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `hienthi`
-- (See below for the actual view)
--
CREATE TABLE `hienthi` (
`ID` int(11)
,`ten` varchar(255)
,`hovaten` varchar(255)
,`dienthoai` varchar(10)
,`namkyhopdong` datetime
);

-- --------------------------------------------------------

--
-- Table structure for table `khoa`
--

CREATE TABLE `khoa` (
  `ID` int(11) NOT NULL,
  `namthanhlap` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `khoa`
--

INSERT INTO `khoa` (`ID`, `namthanhlap`, `ten`) VALUES
(1, 2009, 'Bệnh Tim'),
(2, 2009, 'Bệnh Phổi');

-- --------------------------------------------------------

--
-- Table structure for table `loaibenh`
--

CREATE TABLE `loaibenh` (
  `ID` int(11) NOT NULL,
  `tenbenh` varchar(255) NOT NULL,
  `mota` varchar(500) NOT NULL,
  `trieutrung` text NOT NULL,
  `huongdieutri` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `loaibenh`
--

INSERT INTO `loaibenh` (`ID`, `tenbenh`, `mota`, `trieutrung`, `huongdieutri`) VALUES
(34, 'Tim', 'khó', 'dau', 'thuoc'),
(35, 'Phổi', 'dau', 'sỏ', 'thuoc');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `ID` int(11) NOT NULL,
  `khoa_id` int(11) NOT NULL,
  `hovaten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `namkyhopdong` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`ID`, `khoa_id`, `hovaten`, `dienthoai`, `namkyhopdong`) VALUES
(12, 2, 'Vũ Khánh Linh', '1231231231', '2023-01-05 11:48:25'),
(13, 2, 'Nhung', '2345667892', '2023-01-05 11:48:47');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `tendaydu` varchar(255) NOT NULL,
  `quyenhan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `matkhau`, `tendaydu`, `quyenhan`) VALUES
(1, 'admin', 'admin', 'admin', 1);

-- --------------------------------------------------------

--
-- Structure for view `hienthi`
--
DROP TABLE IF EXISTS `hienthi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `hienthi`  AS SELECT `nhanvien`.`ID` AS `ID`, `khoa`.`ten` AS `ten`, `nhanvien`.`hovaten` AS `hovaten`, `nhanvien`.`dienthoai` AS `dienthoai`, `nhanvien`.`namkyhopdong` AS `namkyhopdong` FROM (`nhanvien` join `khoa`) WHERE `nhanvien`.`khoa_id` = `khoa`.`ID``ID`  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `benhnhan`
--
ALTER TABLE `benhnhan`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `dieutri`
--
ALTER TABLE `dieutri`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `loaibenh_ID` (`loaibenh_ID`),
  ADD KEY `benhnhan` (`benhnhan`),
  ADD KEY `nhanvien_ID` (`nhanvien_ID`);

--
-- Indexes for table `khoa`
--
ALTER TABLE `khoa`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `loaibenh`
--
ALTER TABLE `loaibenh`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `khoa_id` (`khoa_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dieutri`
--
ALTER TABLE `dieutri`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `khoa`
--
ALTER TABLE `khoa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `loaibenh`
--
ALTER TABLE `loaibenh`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `nhanvien`
--
ALTER TABLE `nhanvien`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `dieutri`
--
ALTER TABLE `dieutri`
  ADD CONSTRAINT `dieutri_ibfk_1` FOREIGN KEY (`loaibenh_ID`) REFERENCES `loaibenh` (`ID`),
  ADD CONSTRAINT `dieutri_ibfk_2` FOREIGN KEY (`benhnhan`) REFERENCES `benhnhan` (`ID`),
  ADD CONSTRAINT `dieutri_ibfk_3` FOREIGN KEY (`nhanvien_ID`) REFERENCES `nhanvien` (`ID`);

--
-- Constraints for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD CONSTRAINT `nhanvien_ibfk_1` FOREIGN KEY (`khoa_id`) REFERENCES `khoa` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
