-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 09, 2023 at 04:38 AM
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
-- Database: `tintuc`
--

-- --------------------------------------------------------

--
-- Table structure for table `bophan`
--

CREATE TABLE `bophan` (
  `ID` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bophan`
--

INSERT INTO `bophan` (`ID`, `ten`, `dienthoai`, `email`) VALUES
(1, 'Văn Phòng', '1212121212', 'linh@gmail.'),
(2, 'Kế Toán', '7878787878', 'nhung@gmail.');

-- --------------------------------------------------------

--
-- Table structure for table `chude`
--

CREATE TABLE `chude` (
  `ID` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `mota` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chude`
--

INSERT INTO `chude` (`ID`, `ten`, `mota`) VALUES
(12, 'Văn Hay', '12'),
(13, 'TOán', '13');

-- --------------------------------------------------------

--
-- Table structure for table `chuyenmuc`
--

CREATE TABLE `chuyenmuc` (
  `ID` int(11) NOT NULL,
  `ten` varchar(255) NOT NULL,
  `chude_id` int(11) NOT NULL,
  `mota` varchar(255) NOT NULL,
  `sotutoithieu` int(11) NOT NULL,
  `capdotoithieu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chuyenmuc`
--

INSERT INTO `chuyenmuc` (`ID`, `ten`, `chude_id`, `mota`, `sotutoithieu`, `capdotoithieu`) VALUES
(4, 'An toàn', 12, '23', 90, 15),
(5, 'Tốc độ', 13, 'hay', 80, 16);

-- --------------------------------------------------------

--
-- Table structure for table `tacgia`
--

CREATE TABLE `tacgia` (
  `ID` varchar(32) NOT NULL,
  `phongban_id` int(11) NOT NULL,
  `trangthai` int(11) NOT NULL,
  `capdo` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `hovaten` varchar(255) NOT NULL,
  `dienthoai` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tacgia`
--

INSERT INTO `tacgia` (`ID`, `phongban_id`, `trangthai`, `capdo`, `email`, `hovaten`, `dienthoai`) VALUES
('23', 1, 122222, 17, 'linh@gmail.', 'LInh', '4646464646'),
('6', 2, 464, 45, 'nhung@gmail', 'nhung', '8585858585');

-- --------------------------------------------------------

--
-- Table structure for table `tintuc`
--

CREATE TABLE `tintuc` (
  `ID` int(32) NOT NULL,
  `tacgia_id` varchar(32) NOT NULL,
  `chuyenmuc_id` int(11) NOT NULL,
  `tieude` varchar(255) NOT NULL,
  `motanngan` varchar(255) NOT NULL,
  `noidung` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tintuc`
--

INSERT INTO `tintuc` (`ID`, `tacgia_id`, `chuyenmuc_id`, `tieude`, `motanngan`, `noidung`) VALUES
(1, '6', 5, '11', '1', '1'),
(8, '23', 5, 'An NInh', 'rat hay', 'tot'),
(9, '6', 5, 'hy', 'ko', 'ssss'),
(10, '6', 5, '1', '1', '1'),
(11, '23', 5, '1', '1', '1');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `id` int(11) NOT NULL,
  `quyenhan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `matkhau`, `id`, `quyenhan`) VALUES
('admin', 'admin', 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bophan`
--
ALTER TABLE `bophan`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `chude`
--
ALTER TABLE `chude`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `chuyenmuc`
--
ALTER TABLE `chuyenmuc`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `chude_id` (`chude_id`);

--
-- Indexes for table `tacgia`
--
ALTER TABLE `tacgia`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `phongban_id` (`phongban_id`);

--
-- Indexes for table `tintuc`
--
ALTER TABLE `tintuc`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `tacgia_id` (`tacgia_id`),
  ADD KEY `chuyenmuc_id` (`chuyenmuc_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bophan`
--
ALTER TABLE `bophan`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `chude`
--
ALTER TABLE `chude`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `chuyenmuc`
--
ALTER TABLE `chuyenmuc`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tintuc`
--
ALTER TABLE `tintuc`
  MODIFY `ID` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chuyenmuc`
--
ALTER TABLE `chuyenmuc`
  ADD CONSTRAINT `chuyenmuc_ibfk_1` FOREIGN KEY (`chude_id`) REFERENCES `chude` (`ID`);

--
-- Constraints for table `tacgia`
--
ALTER TABLE `tacgia`
  ADD CONSTRAINT `tacgia_ibfk_1` FOREIGN KEY (`phongban_id`) REFERENCES `bophan` (`ID`);

--
-- Constraints for table `tintuc`
--
ALTER TABLE `tintuc`
  ADD CONSTRAINT `tintuc_ibfk_1` FOREIGN KEY (`tacgia_id`) REFERENCES `tacgia` (`ID`),
  ADD CONSTRAINT `tintuc_ibfk_2` FOREIGN KEY (`chuyenmuc_id`) REFERENCES `chuyenmuc` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
