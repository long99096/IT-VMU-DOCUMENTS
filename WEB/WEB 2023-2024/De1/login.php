<?php
	session_start();
	include('connect.php');
	if(!empty($_POST['submit'])){
		if(isset($_POST['username'])&&isset($_POST['password'])){
			$username = $_POST['username'];
			$password = $_POST['password'];
			$sql = "SELECT * FROM user WHERE username = '$username' AND matkhau = '$password'";
			$stmt = $conn->prepare($sql);
			$query = $stmt->execute();
			$row = $stmt->fetch();
			if(!$row){
				echo "Đăng nhập thất bại";
			}
			else{
				$_SESSION['username'] = $username;
				header("location:index.php");
			}
		}
}
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng nhập</title>
</head>
<body>
    <header><h1>Đăng nhập</h1></header>
    <content>
			<form method="post">

					<label for="username">Tài khoản</label>
					<input type="text" name="username" require>
                    <br>
					<label for="password">Mật khẩu</label>
					<input type="password" name="password" require>
                    <br>
					<input type="submit" name="submit" value="ĐĂNG NHẬP">
					<a href="forgot_password.php">Quên mật khẩu</a>
			</form>
    </content>	
	<footer>Nguyễn Quốc Trung - 92360 - CNT62ĐH</footer>
</body>
</html>