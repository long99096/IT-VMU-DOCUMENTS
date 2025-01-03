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
    <title>Thêm học sinh</title>
</head>
<body>
    <header>
        <h2>Thêm học sinh</h2>
        <img src="logo.png" alt="Logo" style="width:100px; height:auto">
    </header>
    <content>
        <form method='POST'>
            <label for="id">ID:</label>
            <input type="text" name="id">
            <br>
            <label for="hocsinh_id">Học sinh ID:</label>
            <input type="text" name="hocsinh_id">
            <br>
            <label for="namhoc">Năm học:</label>
            <input type="text" name="namhoc">
            <br>
            <label for="nhanxetchung">Nhận xét chung:</label>
            <input type="text" name="nhanxetchung">
            <br>
            <label for="uudiem">Ưu điểm:</label>
            <input type="text" name="uudiem">
            <br>
            <label for="cankhacphuc">Cần khắc phục:</label>
            <input type="text" name="cankhacphuc">
            <br>
            <label for="duoclenlop">Được lên lớp:</label>
            <input type="text" name="duoclenlop">
            <br>
            <input type="submit" value="Tạo mới">
        </form>
        <?php
        include 'connect.php';
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $hocsinh_id=$_POST['hocsinh_id'];
            $namhoc=$_POST['namhoc'];
            $nhanxetchung=$_POST['nhanxetchung'];
            $uudiem=$_POST['uudiem'];
            $cankhacphuc=$_POST['cankhacphuc'];
            $duoclenlop=$_POST['duoclenlop'];

            $sql = "INSERT INTO tongketnam(id,hocsinh_id,namhoc,nhanxetchung,uudiem,cankhacphuc,duoclenlop)
            VALUES('$id','$hocsinh_id','$namhoc','$nhanxetchung','$uudiem','$cankhacphuc','$duoclenlop')";

            if($conn->query($sql)===TRUE){
                header('location:index.php');
                exit();
            }
            $conn->close();
        }
        ?>
    </content>
    <footer>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>