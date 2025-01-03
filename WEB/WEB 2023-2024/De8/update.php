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
    <title>Sửa</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"
     rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <header>
        <h2>Sửa sách</h2>
        <img src='logo.png' alt='logo' style='width:100px; height:auto'>
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['id'])){
            $id=$_GET['id'];
            $sql= "SELECT * FROM sach WHERE id='$id'";
            $result=$conn->query($sql);
            if($result->num_rows>0){
            $row=$result->fetch_assoc();
            ?>
            <form method='POST'>
            <input type='hidden' name='id' value='<?php echo $row['id']; ?>'>
            <br>
            <label for='tensach'>Tên sách:</label>
            <input type='text' name='tensach' value='<?php echo $row['tensach']; ?>'>
            <br>
            <label for='tomtat'>Tóm tắt:</label>
            <input type='text' name='tomtat' value='<?php echo $row['tomtat']; ?>'>
            <br>
            <label for='tacgia'>Tác giả:</label>
            <input type='text' name='tacgia' value='<?php echo $row['tacgia']; ?>'>
            <br>
            <label for='namxb'>Năm xuất bản:</label>
            <input type='text' name='namxb' value='<?php echo $row['namxb']; ?>'>
            <br>
            <label for='loaisach'>Loại sách:</label>
            <input type='text' name='loaisach' value='<?php echo $row['loaisach']; ?>'>
            <br>
            <input type='submit' name='submit' value='Sửa'>
            </form>
        <?php
        }
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $tensach=$_POST['tensach'];
            $tomtat=$_POST['tomtat'];
            $tacgia=$_POST['tacgia'];
            $namxb=$_POST['namxb'];
            $loaisach=$_POST['loaisach'];
            $sql="UPDATE sach SET tensach='$tensach',tomtat='$tomtat',tacgia='$tacgia',namxb='$namxb',
            loaisach='$loaisach' WHERE id='$id'";
            if($conn->query($sql)===TRUE){
                header('location:index.php');
                exit();
            }
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