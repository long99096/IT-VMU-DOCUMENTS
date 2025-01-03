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
    <title>Sửa</title>
</head>
<body>
    <header>
        <h2> Ứng dụng quản lí bảng điều trị </h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['nhanvien_id'])){
            $nhanvien_id=$_GET['nhanvien_id'];
            $sql = "SELECT * FROM dieutri WHERE nhanvien_id='$nhanvien_id'";
            $result=$conn->query($sql);
            if($result->num_rows>0){
            $row=$result->fetch_assoc();
        ?>
            <form method='POST'>
            <input type='hidden' name='nhanvien_id' value='<?php echo $row['nhanvien_id'] ?>'>
            <br>
            <label for='loaibenh'>Loại bệnh: </label>
            <input type='text' name='loaibenh' value='<?php echo $row['loaibenh'] ?>'>
            <br>
            <label for='hovatenbenhnhan'>Họ và tên bệnh nhân: </label>
            <input type='text' name='hovatenbenhnhan' value='<?php echo $row['hovatenbenhnhan'] ?>'>
            <br>
            <label for='ngaybatdau'>Ngày bắt đầu: </label>
            <input type='text' name='ngaybatdau' value='<?php echo $row['ngaybatdau'] ?>'>
            <br>
            <label for='ngayketthuc'>Ngày kết thúc: </label>
            <input type='text' name='ngayketthuc' value='<?php echo $row['ngayketthuc'] ?>'>
            <br>
            <label for='nhanxet'>Nhận xét: </label>
            <input type='text' name='nhanxet' value='<?php echo $row['nhanxet'] ?>'>
            <br>
            <input type='submit' name='submit' value='Sửa'>
        </form>
        <?php
        }
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $nhanvien_id=$_POST['nhanvien_id'];
            $loaibenh=$_POST['loaibenh'];
            $hovatenbenhnhan=$_POST['hovatenbenhnhan'];
            $ngaybatdau=$_POST['ngaybatdau'];
            $ngayketthuc=$_POST['ngayketthuc'];
            $nhanxet=$_POST['nhanxet'];

            $sql="UPDATE dieutri SET loaibenh='$loaibenh',hovatenbenhnhan='$hovatenbenhnhan',ngaybatdau='$ngaybatdau',ngayketthuc='$ngayketthuc',
            nhanxet='$nhanxet' WHERE nhanvien_id='$nhanvien_id'";
            if($conn->query($sql)===TRUE){
                header('location: index.php');
                exit();
            }
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