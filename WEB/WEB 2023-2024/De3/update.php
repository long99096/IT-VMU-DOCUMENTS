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
    <title>Chỉnh sửa</title>
</head>
<body>
    <header>
        <h2> Chỉnh sửa học sinh</h2>
        <img src="logo.png" alt="Logo" style="width:100px; height:auto">
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['id'])){
            $id=$_GET['id'];
            $sql = "SELECT * FROM tongketnam WHERE id='$id'";
            $result = $conn->query($sql);
            if($result->num_rows>0){
                $row=$result->fetch_assoc();
            ?>
                <form method="POST">
                <input type="hidden" name="id" value="<?php echo $row['id']; ?>">
                <label for="hocsinh_id">Học sinh id:</label>
                <input type="text" name="hocsinh_id" value="<?php echo $row['hocsinh_id']; ?>">
                <br>
                <label for="namhoc">Năm học:</label>
                <input type="text" name="namhoc" value="<?php echo $row['namhoc']; ?>">
                <br>
                <label for="nhanxetchung">Nhận xét chung:</label>
                <input type="text" name="nhanxetchung" value="<?php echo $row['nhanxetchung']; ?>">
                <br>
                <label for="uudiem">Ưu điểm:</label>
                <input type="text" name="uudiem" value="<?php echo $row['uudiem']; ?>">
                <br>
                <label for="cankhacphuc">Cần khắc phục:</label>
                <input type="text" name="cankhacphuc" value="<?php echo $row['cankhacphuc']; ?>">
                <br>
                <label for="duoclenlop">Được lên lớp:</label>
                <input type="text" name="duoclenlop" value="<?php echo $row['duoclenlop']; ?>">
                <br>
                <button type="submit"> Chỉnh sửa </button>
                </form>
        <?php
            }
            else{
                echo "Không tìm thấy học sinh nào";
            }
            if($_SERVER['REQUEST_METHOD']=='POST'){
                $id=$_POST['id'];
                $hocsinh_id=$_POST['hocsinh_id'];
                $namhoc=$_POST['namhoc'];
                $nhanxetchung=$_POST['nhanxetchung'];
                $uudiem=$_POST['uudiem'];
                $cankhacphuc=$_POST['cankhacphuc'];
                $duoclenlop=$_POST['duoclenlop'];

                $sql="UPDATE tongketnam SET hocsinh_id=$hocsinh_id, namhoc=$namhoc,nhanxetchung=$nhanxetchung, uudiem=$uudiem,
                cankhacphuc=$cankhacphuc,duoclenlop=$duoclenlop WHERE id=$id";

                if($conn->query($sql)===TRUE){
                    header('location: index.php');
                    exit();
                }
                $conn->close();
            }
        }
        ?>
    </content>
    <footer>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>