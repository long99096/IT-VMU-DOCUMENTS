<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chỉnh sửa đơn hàng</title>
</head>
<body>
    <header>
        <h1>Chỉnh sửa đơn hàng</h1>
        <img src="logo.png" alt="Logo" id="logo">
    </header>
    
    <content>
        <?php

        include 'connect.php';

        if (isset($_GET['id'])) {
            $id = $_GET['id'];
            $sql = "SELECT * FROM donhang WHERE id='$id'";
            $result = $conn->query($sql);

            if ($result->num_rows > 0) {
                $row = $result->fetch_assoc();
                ?>
                <form method="POST" action="">
                    <input type="hidden" id="id" name="id" value="<?php echo $row['id']; ?>">
                    <label for="khachhang_id">Khách hàng ID:</label>
                    <input type="text" id="khachhang_id" name="khachhang_id" value="<?php echo $row['khachhang_id']; ?>" ><br>
                    <label for="trangthai">Trạng thái:</label>
                    <input type="text" id="trangthai" name="trangthai" value="<?php echo $row['trangthai']; ?>" ><br>
                    <label for="khuyenmai">Khuyến mãi:</label>
                    <input type="text" id="khuyenmai" name="khuyenmai" value="<?php echo $row['khuyenmai']; ?>"><br>
                    <label for="ngayban">Ngày bán:</label>
                    <input type="datetime" id="ngayban" name="ngayban" value="<?php echo $row['ngayban']; ?>" ><br>
                    <label for="ngaygiaohang">Ngày giao hàng:</label>
                    <input type="datetime" id="ngaygiaohang" name="ngaygiaohang" value="<?php echo $row['ngaygiaohang']; ?>"><br>
                    <label for="ghichu">Ghi chú:</label>
                    <input type="text" id="ghichu" name="ghichu" value="<?php echo $row['ghichu']; ?>"><br>
                    <button type="submit">Chỉnh sửa</button>
                </form>
                <?php
            } else {
                echo "Không tìm thấy đơn hàng";
            }
        }

        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $id = $_POST['id'];
            $khachhang_id = $_POST['khachhang_id'];
            $trangthai = $_POST['trangthai'];
            $khuyenmai = $_POST['khuyenmai'];
            $ngayban = $_POST['ngayban'];
            $ngaygiaohang = $_POST['ngaygiaohang'];
            $ghichu = $_POST['ghichu'];

            $sql = "UPDATE donhang SET khachhang_id='$khachhang_id', trangthai='$trangthai', khuyenmai='$khuyenmai', 
                    ngayban='$ngayban', ngaygiaohang='$ngaygiaohang', ghichu='$ghichu' WHERE id='$id'";

            if ($conn->query($sql) === TRUE) {
                header("Location: index.php");
                exit();
            } 
            $conn->close();
        }
        ?>
    </content>
    <footer>
        <h2>Nguyễn Quốc Trung - 92360 - N01</h2>
    </footer>
</body>
</html>