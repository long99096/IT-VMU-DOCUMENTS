<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang thêm</title>
</head>
<body>
    <header>
        <h2>Thêm đơn vận</h2>
        <img src='logo.png' alt='Logo' style='width:100px; height:auto'>
    </header>
    <content>
        <form method='POST'>
            <label for='id'>ID:</label>
            <input type='text' name='id'>
            <br>
            <label for='nhanvien_id'>Nhân viên ID:</label>
            <input type='text' name='nhanvien_id'>
            <br>
            <label for='trangthai'>Trạng thái:</label>
            <input type='text' name='trangthai'>
            <br>
            <label for='nguonhang'>Nguồn hàng:</label>
            <input type='text' name='nguonhang'>
            <br>
            <label for='dienthoai'>Điện thoại:</label>
            <input type='text' name='dienthoai'>
            <br>
            <label for='diachi'>Địa chỉ:</label>
            <input type='text' name='diachi'>
            <br>
            <label for='ngaygiaohang'>Ngày giao hàng:</label>
            <input type='text' name='ngaygiaohang'>
            <br>
            <label for='ghichu'>Ghi chú:</label>
            <input type='text' name='ghichu'>
            <br>
            <input type='submit' value='Thêm'>
        </form>
        <?php
            include 'connect.php';
            if($_SERVER['REQUEST_METHOD']=='POST'){
                $id=$_POST['id'];
                $nhanvien_id=$_POST['nhanvien_id'];
                $trangthai=$_POST['trangthai'];
                $nguonhang=$_POST['nguonhang'];
                $dienthoai=$_POST['dienthoai'];
                $diachi=$_POST['diachi'];
                $ngaygiaohang=$_POST['ngaygiaohang'];
                $ghichu=$_POST['ghichu'];

                $sql = "INSERT INTO vandon(id,nhanvien_id,trangthai,nguonhang,dienthoai,diachi,ngaygiaohang,ghichu)
                VALUES('$id','$nhanvien_id','$trangthai','$nguonhang','$dienthoai','$diachi','$ngaygiaohang','$ghichu')";

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