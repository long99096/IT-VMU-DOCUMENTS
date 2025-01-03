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
    <title>Thêm sách</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"
     rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <header>
        <h2>Thêm sách</h2>
        <img src='logo.png' alt='logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='POST'>
        <label for='id'>ID:</label>
        <input type='text' name='id'>
        <br>
        <label for='tensach'>Tên sách:</label>
        <input type='text' name='tensach'>
        <br>
        <label for='tomtat'>Tóm tắt:</label>
        <input type='text' name='tomtat'>
        <br>
        <label for='tacgia'>Tác giả:</label>
        <input type='text' name='tacgia'>
        <br>
        <label for='namxb'>Năm xuất bản:</label>
        <input type='text' name='namxb'>
        <br>
        <label for='loaisach'>Loại sách:</label>
        <input type='text' name='loaisach'>
        <br>
        <input type='submit' name='submit' value='Thêm'>
        </form>
        <?php
        include 'connect.php';
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $tensach=$_POST['tensach'];
            $tomtat=$_POST['tomtat'];
            $tacgia=$_POST['tacgia'];
            $namxb=$_POST['namxb'];
            $loaisach=$_POST['loaisach'];
            $sql="INSERT INTO sach(id,tensach,tomtat,tacgia,namxb,loaisach) VALUES
            ('$id','$tensach','$tomtat','$tacgia','$namxb','$loaisach')";
            if($conn->query($sql)===TRUE){
                header('location:index.php');
                exit();
            }
        }
        $conn->close();
        ?>
    </content>
    <footer>
        <h2>Nguyễn Quốc Trung - 92360 -CNT62ĐH</h2>
    </footer>
</body>
</html>