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
    <title>Sửa phiếu mượn</title>
</head>
<body>
    <header>
        <h2>Sửaphiếu mượn </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['id'])){
            $id=$_GET['id'];
            $sql = "SELECT * FROM phieumuon WHERE id = '$id'";
            $result=$conn->query($sql);
            if($result->num_rows>0){
                $row=$result->fetch_assoc();
                ?>
                <form method='POST'>
                <input type='hidden' name='id' value='<?php echo $row['id']; ?>'>
                <br>
                <label for='nhanvien_id'>Nhân viên:</label>
                <input type='text' name='nhanvien_id' value='<?php echo $row['nhanvien_id']; ?>'>
                <br>
                <label for='docgia_id'>Độc giả ID:</label>
                <input type='text' name='docgia_id' value='<?php echo $row['docgia_id']; ?>'>
                <br>
                <label for='ngaylapphieu'>Ngày lập phiếu:</label>
                <input type='text' name='ngaylapphieu' value='<?php echo $row['ngaylapphieu']; ?>'>
                <br>
                <label for='diengiai'>Điền giải:</label>
                <input type='text' name='diengiai' value='<?php echo $row['diengiai']; ?>'>
                <br>
                <label for='trangthai'>Trạng thái:</label>
                <input type='text' name='trangthai' value='<?php echo $row['trangthai']; ?>'>
                <br>
                <input type='submit' value='Sửa'>
                </form>
            <?php
            }
            if($_SERVER['REQUEST_METHOD']=='POST'){
                $id=$_POST['id'];
                $nhanvien_id=$_POST['nhanvien_id'];
                $docgia_id=$_POST['docgia_id'];
                $ngaylapphieu=$_POST['ngaylapphieu'];
                $diengiai=$_POST['diengiai'];
                $trangthai=$_POST['trangthai'];

                $sql="UPDATE phieumuon SET nhanvien_id='$nhanvien_id',docgia_id='$docgia_id',ngaylapphieu='$ngaylapphieu',
                diengiai='$diengiai',trangthai='$trangthai' WHERE id='$id'";
                
                if($conn->query($sql)===TRUE){
                    header('location:index.php');
                    exit();
                }
            }
            $conn->close();
        }
        ?>
    </content>
    <footer>
        <h2>Nguyễn Quốc Trung - 92360 - CNT62ĐH</h2>
    </footer>
</body>
</html>