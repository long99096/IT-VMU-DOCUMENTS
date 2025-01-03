<?php
    session_start();
    if(!isset($_SESSION["username"])){
        header('location:login.php');
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chỉnh sửa nhân sự</title>
</head>
<body>
    <header>
        <h2> Chỉnh sửa nhân sự </h2>
        <img src="logo.png" alt="Logo" id="logo" style="width:100px; height:auto">
    </header>
    <content>
        <?php
        include 'connect.php';
        if(isset($_GET['id'])){
            $id=$_GET['id'];
            $sql = "SELECT * FROM nhansu WHERE id='$id'";
            $result = $conn->query($sql);
            if($result->num_rows>0){
                $row=$result->fetch_assoc();
            ?>
            <form method="POST">
            <input type="hidden" name="id" value="<?php echo $row["id"]; ?>">
            <label for="phongban_id">Phòng ban id: </label>
            <input type="text" name="phongban_id" value="<?php echo $row["phongban_id"]; ?>">
            <br>
            <label for="trangthai">Trạng thái: </label>
            <input type="text" name="trangthai" value="<?php echo $row["trangthai"]; ?>">
            <br>
            <label for="trinhdo_id">Trình độ id: </label>
            <input type="text" name="trinhdo_id" value="<?php echo $row["trinhdo_id"]; ?>">
            <br>
            <label for="hovaten">Họ và tên: </label>
            <input type="text" name="hovaten" value="<?php echo $row["hovaten"]; ?>">
            <br>
            <label for="dienthoai">Điện thoại: </label>
            <input type="text" name="dienthoai" value="<?php echo $row["dienthoai"]; ?>">
            <br>
            <label for="email">Email: </label>
            <input type="text" name="email" value="<?php echo $row["email"]; ?>">
            <br>
            <button type="submit"> Chỉnh sửa </button>
        </form>
        <?php
        }
        else{
            echo"Không tìm thấy nhân sự";
        }
        }
        if($_SERVER['REQUEST_METHOD']=='POST'){
            $id=$_POST['id'];
            $phongban_id=$_POST['phongban_id'];
            $trangthai=$_POST['trangthai'];
            $trinhdo_id=$_POST['trinhdo_id'];
            $hovaten=$_POST['hovaten'];
            $dienthoai=$_POST['dienthoai'];
            $email=$_POST['email'];

            $sql = "UPDATE nhansu SET phongban_id=$phongban_id,trangthai=$trangthai,trinhdo_id=$trinhdo_id,hovaten='$hovaten',
            dienthoai='$dienthoai', email='$email' WHERE id='$id'";
            if($conn->query($sql)===TRUE){
                header("Location: index.php");
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