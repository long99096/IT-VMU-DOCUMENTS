<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quên mật khẩu</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"
    rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form method='POST'>
        <label for='username'>Tài khoản: </label>
        <input type='text' name='username'>
        <br>
        <label for='password'>Mật khẩu: </label>
        <input type='password' name='password'>
        <br>
        <label for='nhaplai'>Mật khẩu: </label>
        <input type='password' name='nhaplai'>
        <br>

        <input type='submit' name='submit' value='Đặt lại mật khẩu'>
        </form>
        <?php
        include 'connect.php';
        session_start();
        if(!empty($_POST['submit'])){
            if(isset($_POST['username'])&&isset($_POST['password'])&&isset($_POST['nhaplai'])){
                $username=$_POST['username'];
                $password=$_POST['password'];
                $nhaplai=$_POST['nhaplai'];
                if($nhaplai==$password)
                $sql="UPDATE user SET matkhau='$password' WHERE username='$username'";
                $stmt=$conn->prepare($sql);
                $query=$stmt->execute();
                header('location: login.php');
                }
            }
            $conn->close();
        ?>
</body>
</html>