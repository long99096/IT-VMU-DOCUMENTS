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
    <title>Trang chính</title>
</head>
<body>
    <header>
        <h2> Tổng kết năm </h2>
        <img src="logo.png" alt="Logo" style="width:100px; height:auto">
    </header>
    <content>
        <h2> Danh sách học sinh </h2>
        <form method="GET">
            <label for="search">Tìm kiếm: </label>
            <input type="text" name="search">
            <button type="submit">Tìm kiếm</button>
        <form>
        <table>
            <thred>
                <tr>
                    <th>ID</th>
                    <th>Học sinh id</th>
                    <th>Năm học</th>
                    <th>Nhận xét chung</th>
                    <th>Ưu điểm</th>
                    <th>Cần khắc phục</th>
                    <th>Được lên lớp</th>
                </tr>
            </thred>
            <tbody>
                <?php
                include 'connect.php';

                $search = isset($_GET['search']) ? $_GET['search'] : '';
                $sql = "SELECT * FROM tongketnam";
                if($search!==''){
                    $sql .= " WHERE id LIKE '$search' OR hocsinh_id LIKE '$search'";
                }


                $result = $conn->query($sql);
                if($result->num_rows>0){
                    while($row=$result->fetch_assoc()){
                        echo "<tr><td>" .$row['id'].
                        "</td><td>" .$row['hocsinh_id'].
                        "</td><td>" .$row['namhoc'].
                        "</td><td>" .$row['nhanxetchung'].
                        "</td><td>" .$row['uudiem'].
                        "</td><td>" .$row['cankhacphuc'].
                        "</td><td>" .$row['duoclenlop'].
                        "</td><td><a href='update.php?id=" .$row["id"]. "'>Chỉnh sửa</a></td>
                        <td><a href='delete.php?id=" .$row['id']. "'>Xóa</a></td>
                        </tr>";
                    }
                }
                else{
                    echo "<tr><td colspan='7'> Không có học sinh nào </td></tr>";
                }
                $conn->close();
                ?>
            </tbody>
        </table>
        <h2> <a href='add.php'> Thêm học sinh </a></h2>
    </content>
    <footer>
        <p> Xin chào <?php echo($_SESSION['username']); ?></P>
        <a href="logout.php">Đăng xuất</a>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>