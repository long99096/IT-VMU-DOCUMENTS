<?php
	session_start();
	if(!isset($_SESSION['username'])){
		header('location:login.php');
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quản lí đơn hàng</title>
</head>
<body>
    <header>
        <h1> Website quản lí đơn hàng </h1>
        <img src="logo.png" alt="Logo" id="logo">
        
    </header>
    
    <content>
        <h1> Danh sách các đơn hàng </h1>
        <form method="GET" action="">
            <label for="search">Tìm kiếm đơn hàng:</label>
            <input type="text" id="search" name="search">
            <button type="submit">Tìm kiếm</button>
        </form>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>khachhang_id</th>
                    <th>Trạng thái</th>
                    <th>Khuyến mãi</th>
                    <th>Ngày bán</th>
                    <th>Ngày giao hàng</th>
                    <th>Ghi chú</th>
                </tr>
            </thead>
            <tbody>
                <?php
                include 'connect.php';

                $search = isset($_GET['search']) ? $_GET['search'] : '';
                $sql = "SELECT * FROM donhang";

                if ($search !== '') {
                    $sql .= " WHERE id LIKE '$search' OR khachhang_id LIKE '$search'";
                }

                $result = $conn->query($sql);
                
                if($result->num_rows>0){
                    while($row = $result->fetch_assoc()){
                        echo "<tr>
                                <td>" .$row["id"]."</td>
                                <td>" .$row["khachhang_id"]."</td>
                                <td>" .$row["trangthai"]."</td>
                                <td>" .$row["khuyenmai"]."</td>
                                <td>" .$row["ngayban"]."</td>
                                <td>" .$row["ngaygiaohang"]."</td>
                                <td>" .$row["ghichu"]."</td>
                                <td><a href='update.php?id=" . $row["id"] . "'>Chỉnh sửa</a></td>
                                <td><a href='delete.php?id=" . $row["id"] . "' onclick='return confirm(\"Bạn có chắc chắn muốn xóa đơn hàng này?\")'>Xóa</a></td>
                            </tr>";
                    }
                }
                else{
                    echo "<tr><td colspan='7'>Không có vận đơn hàng nào</td></tr>";
                }
                $conn->close();
                ?>
            </tbody>
        </table>
        <h2><a href="add.php">Tạo mới đơn hàng</a></h2>
    </content>
    <footer>
        <p> XIN CHÀO <?php echo($_SESSION['username']) ?> </p>
        <p><a href="logout.php">Đăng xuất</a></P>
        <h2>Nguyễn Quốc Trung - 92360 - N01 </h2>
    </footer>
</body>
</html>