<?php
    session_start();
    if(!isset($_SESSION["username"])){
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
        <h2> Ứng dụng quản lí nhân sự </h2>
        <img src="logo.png" alt="Logo" id="logo" style="width:100px; height:auto">
    </header>
    <content>
        <h2> Danh sách nhân sự </h2>
        <form method="GET">
            <label for="search">Tìm kiếm nhân sự: </label>
            <input type="text" name="search">
            <button type="submit">Tìm kiếm</button>
        </form>
        <table>
            <thred>
                <tr>
                    <th>ID</th>
                    <th>Phòng ban id</th>
                    <th>Trạng thái</th>
                    <th>Trình độ id</th>
                    <th>Họ và tên</th>
                    <th>Điện thoại</th>
                    <th>Email</th>
                </tr>
            </thred>
            <tbody>
                <?php
                include 'connect.php';

                $search = isset($_GET['search']) ? $_GET['search'] : '';
                $sql = "SELECT * FROM nhansu";
                if($search !== ''){
                    $sql .= " WHERE hovaten LIKE '%$search%' ";
                }

                $result = $conn->query($sql);

                if($result->num_rows>0){
                    while($row=$result->fetch_assoc()){
                        echo"<tr><td>" 
                        .$row["id"]. "</td><td>"
                        .$row["phongban_id"]. "</td><td>"
                        .$row["trangthai"]. "</td><td>"
                        .$row["trinhdo_id"]. "</td><td>"
                        .$row["hovaten"]. "</td><td>"
                        .$row["dienthoai"]. "</td><td>"
                        .$row["email"]. "</td><td>
                        <a href='update.php?=".$row["id"]."'>Chỉnh sửa</a></td>
                        <td><a href='delete.php?=".$row["id"]."'>Xóa</a></td>
                        </tr>";
                    }
                }
                else{
                    echo "<tr><td colspan='7'>Không có nhân sự nào</td></tr>";
                }
                $conn->close();
                ?>
            </tbody>
        </table>
        <h3> <a href="add.php"> Thêm mới nhân sự </a></h3>
    </content>
    <footer>
        <p> Xin chào <?php echo($_SESSION['username']) ?> </p>
        <p><a href="logout.php">Đăng xuất</a></p>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>