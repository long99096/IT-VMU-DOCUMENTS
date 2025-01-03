<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang sửa</title>
</head>
<body>
    <header>
        <h2>Sửa đơn vận</h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['id'])){
            $id=$_GET['id'];
            $sql = "SELECT * FROM vandon WHERE id='$id'";
            $result=$conn->query($sql);
            if($result->num_rows>0){
                $row=$result->fetch_assoc();
        ?>
        <form method='POST'>
        <input type='hidden' name='id' value='<?php echo $row['id']; ?>'>
        <label for='nhanvien_id'>Nhân viên ID:</label>
        <input type='text' name='nhanvien_id' value='<?php echo $row['nhanvien_id']; ?>'>
        <br>
        <label for='trangthai'>Trạng thái:</label>
        <input type='text' name='trangthai' value='<?php echo $row['trangthai']; ?>'>
        <br>
        <label for='nguonhang'>Nguồn hàng:</label>
        <input type='text' name='nguonhang' value='<?php echo $row['nguonhang']; ?>'>
        <br>
        <label for='dienthoai'>Điện thoại:</label>
        <input type='text' name='dienthoai' value='<?php echo $row['dienthoai']; ?>'>
        <br>
        <label for='diachi'>Địa chỉ:</label>
        <input type='text' name='diachi' value='<?php echo $row['diachi']; ?>'>
        <br>
        <label for='ngaygiaohang'>Ngày giao hàng:</label>
        <input type='text' name='ngaygiaohang' value='<?php echo $row['ngaygiaohang']; ?>'> 
        <br>
        <label for='ghichu'>Ghi chú:</label>
        <input type='text' name='ghichu' value='<?php echo $row['ghichu']; ?>'>
        <br>
        <input type='submit' value='Sửa'>
        </form>
        <?php
        }
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $nhanvien_id=$_POST['nhanvien_id'];
            $trangthai=$_POST['trangthai'];
            $nguonhang=$_POST['nguonhang'];
            $dienthoai=$_POST['dienthoai'];
            $diachi=$_POST['diachi'];
            $ngaygiaohang=$_POST['ngaygiaohang'];
            $ghichu=$_POST['ghichu'];
            
            $sql="UPDATE vandon SET nhanvien_id='$nhanvien_id', trangthai='$trangthai',  nguonhang='$nguonhang',  dienthoai='$dienthoai',
            diachi='$diachi',  ngaygiaohang='$ngaygiaohang', ghichu='$ghichu' WHERE id='$id'";
        }
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