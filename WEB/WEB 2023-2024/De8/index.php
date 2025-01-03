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
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">   
</head>
<body>
    <header>
        <h2>Ứng dụng quản lí sách</h2>
        <img src='logo.png' alt='logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='GET'>
        <label for='search'>Tìm kiếm sách:</label>
        <input type='text' name='search'>
        <input type='submit' name='submit' value='Tìm kiếm' >
        </form>
        <table class="table">
            <tr>
                <th>ID</th>
                <th>Tên sách</th>
                <th>Tóm tắt</th>
                <th>Tác giả</th>
                <th>Năm xuất bản</th>
                <th>Loại sách</th>
            </tr>
            <?php
            include 'connect.php';
            $search = isset($_GET['search']) ? $_GET['search'] : '';
            $sql="SELECT * FROM sach";
            if($search!==''){
                $sql .= " WHERE tensach='$search' OR tacgia = '$search'";
            }
            $result=$conn->query($sql);
            if($result->num_rows>0){
                while($row=$result->fetch_assoc()){
                    echo "<tr><td>".$row['id'].
                    "</td><td>" .$row['tensach'].
                    "</td><td>" .$row['tomtat'].
                    "</td><td>" .$row['tacgia'].
                    "</td><td>" .$row['namxb'].
                    "</td><td>" .$row['loaisach'].
                    "</td><td><a href='update.php?id=".$row['id']."'>Sửa</a></td>
                    <td><a href='delete.php?id=".$row['id']."'>Xóa</a></td>
                    </tr>";
                }
            }else{
                echo "<tr><td colspan='6'>Không tìm thấy sách nào</td></tr>";
            }
            $conn->close();
            ?>
        </table>
        <h3> <a href='add.php'> Thêm sách </a> </h3>
    </content>
    <footer>
        <p> Xin chào <?php echo $_SESSION['username']; ?>
        <a href='logout.php'>Đăng xuất</a>
        <h2>Nguyễn Quốc Trung - 92360 -CNT62ĐH</h2>
    </footer>
</body>
</html>