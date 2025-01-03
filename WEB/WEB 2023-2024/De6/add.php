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
    <title>Thêm</title>
</head>
<body>
    <header>
        <h2> Ứng dụng quản lí bảng điều trị </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='POST'>
            <label for='nhanvien_id'>Nhân viên id: </label>
            <input type='text' name='nhanvien_id'>
            <br>
            <label for='loaibenh'>Loại bệnh: </label>
            <input type='text' name='loaibenh'>
            <br>
            <label for='hovatenbenhnhan'>Họ và tên bệnh nhân: </label>
            <input type='text' name='hovatenbenhnhan'>
            <br>
            <label for='ngaybatdau'>Ngày bắt đầu: </label>
            <input type='text' name='ngaybatdau'>
            <br>
            <label for='ngayketthuc'>Ngày kết thúc: </label>
            <input type='text' name='ngayketthuc'>
            <br>
            <label for='nhanxet'>Nhận xét: </label>
            <input type='text' name='nhanxet'>
            <br>
            <input type='submit' name='submit' value='Thêm'>
        </form>
        <?php
            include 'connect.php';
            if($_SERVER['REQUEST_METHOD']=='POST'){
                $nhanvien_id=$_POST['nhanvien_id'];
                $loaibenh=$_POST['loaibenh'];
                $hovatenbenhnhan=$_POST['hovatenbenhnhan'];
                $ngaybatdau=$_POST['ngaybatdau'];
                $ngayketthuc=$_POST['ngayketthuc'];
                $nhanxet=$_POST['nhanxet'];

                $sql="INSERT INTO dieutri(nhanvien_id,loaibenh,hovatenbenhnhan,ngaybatdau,ngayketthuc,nhanxet)
                VALUES('$nhanvien_id','$loaibenh','$hovatenbenhnhan','$ngaybatdau','$ngayketthuc','$nhanxet')";
                if($conn->query($sql)===TRUE){
                    header('location: index.php');
                    exit();
                }
            }
            $conn->close();
        ?>
    </content>
    <footer>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>