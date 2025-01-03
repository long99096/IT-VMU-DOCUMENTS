<?php
session_start();
if(!isset($_SESSION['username'])){
    header('location: login.php');
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chính</title>
</head>
<body>
    <header>
        <h2> Ứng dụng quản lí phiếu mượn </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='GET'>
            <label for='search'> Tìm kiếm phiếu mượn: </label>
            <input type='text' name='search'>
            <input type='submit' value='Tìm kiếm'>
        </form>
        <table>
            <tr>
                <th>ID</th>
                <th>Nhân viên ID</th>
                <th>Độc giả ID</th>
                <th>Ngày lập phiếu</th>
                <th>Điền giải</th>
                <th>Trạng thái</th>
            </tr>
            <?php
            include 'connect.php';
            $search= isset($_GET['search']) ? $_GET['search'] : '';
            $sql = "SELECT * FROM phieumuon";
            if($search!==''){
                $sql .= " WHERE nhanvien_id LIKE '$search' OR docgia_id LIKE '$search'";
            }
            $result=$conn->query($sql);
            if($result->num_rows>0){
                while($row=$result->fetch_assoc()){
                    echo "<tr><td>" .$row['id'].
                    "</td><td>" .$row['nhanvien_id'].
                    "</td><td>" .$row['docgia_id'].
                    "</td><td>" .$row['ngaylapphieu'].
                    "</td><td>" .$row['diengiai'].
                    "</td><td>" .$row['trangthai'].
                    "</td><td><a href='update.php?id=".$row['id']."'>Sửa</a></td>
                    <td><a href='delete.php?id=".$row['id']."'>Xóa</a></td>
                    </tr>";
                }
            }else{
                    echo "<tr><td colspan='6'> Không tìm thấy phiếu mượn nào </td></tr>";
                }
            $conn->close();
            ?>
        </table>
        <h3><a href='add.php'> Thêm phiếu mượn </a></h3>
    </content>
    <footer>
        <p>Xin chào: <?php echo $_SESSION['username']; ?>
        <a href='logout.php'>Đăng xuất </a></p>
        <h2>Nguyễn Quốc Trung - 92360 - CNT62ĐH</h2>
    </footer>
</body>
</html>