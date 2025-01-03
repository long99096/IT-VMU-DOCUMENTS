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
        <h2> Ứng dụng quản lí bảng điều trị </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='GET'>
            <label for='search'>Tìm kiếm: </label>
            <input type='text' name='search'>
            <input type='submit' name='submit' value='Tìm kiếm'>
        </form>
        <table>
            <tr>
                <th>Nhân viên id</th>
                <th>Loại bệnh</th>
                <th>Họ và tên bệnh nhân</th>
                <th>Ngày bắt đầu</th>
                <th>Ngày kết thúc</th>
                <th>Nhận xét</th>
            </tr>
            <?php
            include 'connect.php';
            $search = isset($_GET['search']) ? $_GET['search'] : '';
            $sql="SELECT * FROM dieutri";
            if($search!==''){
                $sql .= " WHERE nhanvien_id LIKE '$search' OR hovatenbenhnhan LIKE '$search'";
            }
            $result = $conn->query($sql);
            if($result->num_rows>0){
                while($row=$result->fetch_assoc()){
                    echo "<tr><td>" .$row['nhanvien_id'].
                    "</td><td>" .$row['loaibenh'].
                    "</td><td>" .$row['hovatenbenhnhan'].
                    "</td><td>" .$row['ngaybatdau'].
                    "</td><td>" .$row['ngayketthuc'].
                    "</td><td>" .$row['nhanxet'].
                    "</td><td><a href='update.php?nhanvien_id=".$row['nhanvien_id']."'>Sửa</a></td>
                    <td><a href='delete.php?nhanvien_id=".$row['nhanvien_id']."'>Xóa</a></td>
                    </tr>";
                }
            }
            else{
                echo "<tr><td colspan='6'>Không có bảng điều trị nào</td></tr>";
            }
            $conn->close();
            ?>
        </table>
        <h3> <a href='add.php'> Thêm bảng điều trị <a> <h3>
    </content>
    <footer>
        <p> Xin chào: <?php echo $_SESSION['username'];  ?>
        <a href='logout.php'> Đăng xuất </a> </p>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>