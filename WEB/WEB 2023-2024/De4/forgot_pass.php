<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quên mật khẩu</title>
</head>
<body>
    <header>
        <h2>Quên mật khẩu</h2>
    </header>
    <content>
        <?php
        include 'connect.php';
        session_start();
        if(!empty($_POST['submit'])){
            if(isset($_POST['username']) && isset($_POST['password']) && isset($_POST['nhaplai'])){
                $username = $_POST['username'];
                $password = $_POST['password'];
                $nhaplai=$_POST['nhaplai'];
                if($nhaplai==$password){
                $sql="UPDATE user SET matkhau='$password' WHERE username='$username'";
                $stmt = $conn->prepare($sql);
                $query=$stmt->execute();
                header('location:index.php');
                }
            }
        }
        ?>
        <form method='POST'>
            <label for='username'>Tài khoản:</label>
            <input type='text' name='username'>
            <br>
            <label for='password'>Mật khẩu:</label>
            <input type='password' name='password'>
            <br>
            <label for='nhaplai'>Nhập lại mật khẩu:</label>
            <input type='password' name='nhaplai'>
            <br>
            <input type='submit' name='submit' value='Đổi mật khẩu'> 
        </form>
    </content>
    <footer>
        <h2> Nguyễn Quốc Trung - 92360 - CNT62ĐH </h2>
    </footer>
</body>
</html>