<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tạo mới đơn hàng</title>
</head>
<body>
    <header>
        <h1>Tạo mới đơn hàng</h1>
        <img src="logo.png" alt="Logo" id="logo">
    </header>
    
    <content>
        <form method="POST" action="">
            <label for="id">ID:</label>
            <input type="text" id="id" name="id"><br>
            <label for="khachhang_id">Khách hàng ID:</label>
            <input type="text" id="khachhang_id" name="khachhang_id"><br>
            <label for="trangthai">Trạng thái:</label>
            <input type="text" id="trangthai" name="trangthai"><br>
            <label for="khuyenmai">Khuyến mãi:</label>
            <input type="text" id="khuyenmai" name="khuyenmai"><br>
            <label for="ngayban">Ngày bán:</label>
            <input type="datetime" id="ngayban" name="ngayban"><br>
            <label for="ngaygiaohang">Ngày giao hàng:</label>
            <input type="datetime" id="ngaygiaohang" name="ngaygiaohang"><br>
            <label for="ghichu">Ghi chú:</label>
            <input type="text" id="ghichu" name="ghichu"><br>
            <button type="submit">Tạo mới</button>
        </form>

        <?php
        
        include 'connect.php';
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $id = $_POST['id'];
            $khachhang_id = $_POST['khachhang_id'];
            $trangthai = $_POST['trangthai'];
            $khuyenmai = $_POST['khuyenmai'];
            $ngayban = $_POST['ngayban'];
            $ngaygiaohang = $_POST['ngaygiaohang'];
            $ghichu = $_POST['ghichu'];

            $sql = "INSERT INTO donhang (id, khachhang_id, trangthai, khuyenmai, ngayban, ngaygiaohang, ghichu)
                    VALUES ($id, '$khachhang_id', '$trangthai', '$khuyenmai', '$ngayban', '$ngaygiaohang', '$ghichu')";

            if ($conn->query($sql) === TRUE) {
                header("Location: index.php");
                exit();
            } else {
                echo "Lỗi: " . $sql . "<br>" . $conn->error;
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