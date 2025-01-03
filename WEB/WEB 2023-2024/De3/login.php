<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng nhập</title>
</head>
<body>
    <header><h2>Đăng nhập</h2></header>
    <content>
        <?php
        session_start();
        include 'connect.php';
        if(!empty($_POST['submit'])){
            if(isset($_POST['username']) && isset($_POST['password'])){
                $username=$_POST['username'];
                $password=$_POST['password'];
                $sql = "SELECT * FROM user WHERE username = '$username' && matkhau = '$password'";
                $stmt=$conn->prepare($sql);
                $query=$stmt->execute();
                $row=$stmt->fetch();
                if(!$row){
                    echo "Đăng nhập thất bại";
                }
                else{
                    header('location: index.php');
                    $_SESSION['username']=$username;
                }

            }
        }
        ?>
        <form method='POST'>
            <label for="username">Tài khoản:</label>
            <input type="text" name="username" require>
            <br>
            <label for="password">Tài khoản:</label>
            <input type="password" name="password" require>
            <br>
            <input type="submit" name="submit" value="Đăng nhập">
            <a href="forgot_pass.php">Quên mật khẩu</a>
        <form>
    </content>
    <footer>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>