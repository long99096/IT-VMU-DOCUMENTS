<?php
include 'connect.php';
session_start();
if(!empty($_POST['submit'])){
    if($_POST['submit'] == 'login'){
        $username = $_POST['username'];
        $matkhau = $_POST['matkhau'];
        $xacnhan = $_POST['confirm_matkhau'];
        if($xacnhan === $matkhau){
            $sql = "update user set matkhau='$matkhau' where username = '$username'";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();
        header('location: login.php');
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
        <form action="" method="post">
                <label for="username">Username</label>
                <input type="text"  id="username" name='username'>
                <br>
                <label for="matkhau">New Password</label>
                <input type="password" id="matkhau" name='matkhau'>
                <br>
                <label for="confirm_matkhau">Confirm Password</label>
                <input type="password" id="confirm_matkhau" name='confirm_matkhau'>
                <br>
                <button type='submit' name='submit' value='login'>Change password</button>
        </form>
</body>
</html>