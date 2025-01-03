-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 28, 2024 lúc 02:56 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `hocsinh`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tongketnam`
--

CREATE TABLE `tongketnam` (
  `id` int(11) NOT NULL,
  `hocsinh_id` varchar(32) NOT NULL,
  `namhoc` varchar(9) NOT NULL,
  `nhanxetchung` text NOT NULL,
  `uudiem` text NOT NULL,
  `cackhacphuc` text NOT NULL,
  `duoclenlop` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tongketnam`
--

INSERT INTO `tongketnam` (`id`, `hocsinh_id`, `namhoc`, `nhanxetchung`, `uudiem`, `cackhacphuc`, `duoclenlop`) VALUES
(1, '123', '2023', 'Tot da sua', 'Uu diem', 'Khong', 0);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tongketnam`
--
ALTER TABLE `tongketnam`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `tongketnam`
--
ALTER TABLE `tongketnam`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
