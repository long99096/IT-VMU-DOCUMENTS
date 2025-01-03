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
    <title>Thêm phiếu mượn</title>
</head>
<body>
    <header>
        <h2>Thêm phiếu mượn </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='POST'>
            <label for='id'>ID:</label>
            <input type='text' name='id'>
            <br>
            <label for='nhanvien_id'>Nhân viên:</label>
            <input type='text' name='nhanvien_id'>
            <br>
            <label for='docgia_id'>Độc giảID:</label>
            <input type='text' name='docgia_id'>
            <br>
            <label for='ngaylapphieu'>Ngày lập phiếu:</label>
            <input type='text' name='ngaylapphieu'>
            <br>
            <label for='diengiai'>Điền giải:</label>
            <input type='text' name='diengiai'>
            <br>
            <label for='trangthai'>Trạng thái:</label>
            <input type='text' name='trangthai'>
            <br>
            <input type='submit' value='Thêm'>
        </form>
        <?php
        include 'connect.php';
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $nhanvien_id=$_POST['nhanvien_id'];
            $docgia_id=$_POST['docgia_id'];
            $ngaylapphieu=$_POST['ngaylapphieu'];
            $diengiai=$_POST['diengiai'];
            $trangthai=$_POST['trangthai'];
            $sql = "INSERT INTO phieumuon(id,nhanvien_id,docgia_id,ngaylapphieu,diengiai,trangthai)
            VALUES('$id','$nhanvien_id','$docgia_id','$ngaylapphieu','$diengiai','$trangthai')";
            if($conn->query($sql)===TRUE){
                header('location:index.php');
                exit();
            }
        }
        $conn->close();
        ?>
    </content>
    <footer>
        <h2>Nguyễn Quốc Trung - 92360 - CNT62ĐH</h2>
    </footer>
</body>
</html>