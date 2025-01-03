-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2023 at 04:36 AM
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
-- Database: `dh`
--

-- --------------------------------------------------------

--
-- Table structure for table `ketquathi`
--

CREATE TABLE `ketquathi` (
  `ID` int(11) NOT NULL,
  `monhoc_id` int(11) NOT NULL,
  `sinhvien_id` varchar(32) NOT NULL,
  `loaidiem` int(11) NOT NULL,
  `lanthi` int(11) NOT NULL,
  `diem` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ketquathi`
--

INSERT INTO `ketquathi` (`ID`, `monhoc_id`, `sinhvien_id`, `loaidiem`, `lanthi`, `diem`) VALUES
(5, 2, '5', 9, 1, '10'),
(6, 2, '6', 3, 2, '5');

-- --------------------------------------------------------

--
-- Table structure for table `khoa`
--

CREATE TABLE `khoa` (
  `ID` int(11) NOT NULL,
  `namthanhlap` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `khoa`
--

INSERT INTO `khoa` (`ID`, `namthanhlap`, `ten`) VALUES
(1, 2009, 'Công nghệ '),
(2, 1, 'ten 1');

-- --------------------------------------------------------

--
-- Table structure for table `lophanhchinh`
--

CREATE TABLE `lophanhchinh` (
  `ID` int(11) NOT NULL,
  `tenlop` varchar(255) NOT NULL,
  `namthanhlap` int(11) NOT NULL,
  `khoa_id` int(11) NOT NULL,
  `siso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `lophanhchinh`
--

INSERT INTO `lophanhchinh` (`ID`, `tenlop`, `namthanhlap`, `khoa_id`, `siso`) VALUES
(1, 'Công nghệ thông tin', 2009, 1, 46),
(2, 'ten lop 1', 1, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `monhoc`
--

CREATE TABLE `monhoc` (
  `ID` int(11) NOT NULL,
  `khoa_id` int(11) NOT NULL,
  `tenmon` varchar(255) NOT NULL,
  `sotinchi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `monhoc`
--

INSERT INTO `monhoc` (`ID`, `khoa_id`, `tenmon`, `sotinchi`) VALUES
(2, 1, 'Anh', 3),
(3, 1, 'Toán', 4);

-- --------------------------------------------------------

--
-- Table structure for table `sinhvien`
--

CREATE TABLE `sinhvien` (
  `ID` varchar(32) NOT NULL,
  `trangthai` int(11) NOT NULL,
  `lop_id` int(11) NOT NULL,
  `hovaten` varchar(255) NOT NULL,
  `ngaysinh` datetime NOT NULL,
  `mota` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sinhvien`
--

INSERT INTO `sinhvien` (`ID`, `trangthai`, `lop_id`, `hovaten`, `ngaysinh`, `mota`) VALUES
('2', 2, 2, 'ho va ten 2', '2023-01-25 09:52:48', 'mo ta 2'),
('3', 3, 1, 'tuan', '2023-01-13 09:57:00', '3'),
('5', 122222, 1, 'Vũ Khánh Linh', '2023-01-01 12:00:19', 'ko'),
('6', 222222, 1, 'Nhung', '2023-01-01 12:00:39', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `tendaydu` varchar(255) NOT NULL,
  `quyenhan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `matkhau`, `tendaydu`, `quyenhan`) VALUES
(1, 'admin', 'admin', 'admin', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ketquathi`
--
ALTER TABLE `ketquathi`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `sinhvien_id` (`sinhvien_id`),
  ADD KEY `monhoc_id` (`monhoc_id`);

--
-- Indexes for table `khoa`
--
ALTER TABLE `khoa`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `lophanhchinh`
--
ALTER TABLE `lophanhchinh`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `khoa_id` (`khoa_id`);

--
-- Indexes for table `monhoc`
--
ALTER TABLE `monhoc`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `khoa_id` (`khoa_id`);

--
-- Indexes for table `sinhvien`
--
ALTER TABLE `sinhvien`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `lop_id` (`lop_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ketquathi`
--
ALTER TABLE `ketquathi`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `khoa`
--
ALTER TABLE `khoa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `lophanhchinh`
--
ALTER TABLE `lophanhchinh`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `monhoc`
--
ALTER TABLE `monhoc`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ketquathi`
--
ALTER TABLE `ketquathi`
  ADD CONSTRAINT `ketquathi_ibfk_1` FOREIGN KEY (`sinhvien_id`) REFERENCES `sinhvien` (`ID`),
  ADD CONSTRAINT `ketquathi_ibfk_2` FOREIGN KEY (`monhoc_id`) REFERENCES `monhoc` (`ID`);

--
-- Constraints for table `lophanhchinh`
--
ALTER TABLE `lophanhchinh`
  ADD CONSTRAINT `lophanhchinh_ibfk_1` FOREIGN KEY (`khoa_id`) REFERENCES `khoa` (`ID`);

--
-- Constraints for table `monhoc`
--
ALTER TABLE `monhoc`
  ADD CONSTRAINT `monhoc_ibfk_1` FOREIGN KEY (`khoa_id`) REFERENCES `khoa` (`ID`);

--
-- Constraints for table `sinhvien`
--
ALTER TABLE `sinhvien`
  ADD CONSTRAINT `sinhvien_ibfk_1` FOREIGN KEY (`lop_id`) REFERENCES `lophanhchinh` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
