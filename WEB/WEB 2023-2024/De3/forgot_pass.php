<?php
    include 'connect.php';
    session_start();
    if(!empty($_POST['submit'])){
        if(isset($_POST['username'])&&isset($_POST['matkhau'])&&isset($_POST['nhaplai'])){
            $username=$_POST['username'];
            $matkhau=$_POST['matkhau'];
            $nhaplai=$_POST['nhaplai'];
            if($nhaplai==$matkhau){
                $sql="UPDATE user SET matkhau = '$matkhau' where username='$username'";
                $stmt=$conn->prepare($sql);
                $query=$stmt->execute();
                header('location:login.php');
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quên mật khẩu</title>
</head>
<body>
    <form method="POST">
        <label for="username">Username:</label>
        <input type="text" name="username" require>
        <br>
        <label for="matkhau">Mật khẩu mới:</label>
        <input type="password" name="matkhau" require>
        <br>
        <label for="nhaplai">Nhập lại mật khẩu:</label>
        <input type="password" name="nhaplai" require>
        <br>
        <input type="submit" value="Đổi mật khẩu" name="submit">
    </form>
</body>
</html>