<?php
session_start();
include('connect.php');
if(!empty($_POST['submit'])){
	if(isset($_POST['username'])&&isset($_POST['password'])){
		$username = $_POST['username'];
		$password = $_POST['password'];
		$sql = "select * from user where username = '$username' and matkhau = '$password'";
		$stmt = $conn->prepare($sql);
	$query = $stmt->execute();

	$row = $stmt->fetch(PDO::FETCH_ASSOC);
	if(!$row){
		echo "Dang nhap that bai";
	}
	else{
		$_SESSION['tendaydu'] = $username;
		header("location:admin.php");

	}

	}
}
?>
<!DOCTYPE html>
<html>
<head>
	<title>Trang Đăng Nhập</title>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<script type="text/javascript" src="js/jquery-3.5.1.slim.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
	<header>QUẢN LÝ VẬN ĐƠN</header>
	<content>
		<div class="container">
			<form method="post">
				<fieldset class="form-group">
					<label for="formGroupExampleInput">Tài khoản</label>
					<input type="text" class="form-control"name="username" placeholder="Nhập tài khoản">
				</fieldset>
				<fieldset class="form-group">
					<label for="formGroupExampleInput2">Mật khẩu</label>
					<input type="password" class="form-control" name="password" placeholder="Nhập mật khẩu">
				</fieldset>
				<fieldset class="form-group">
					<input type="submit" class="form-control" name="submit" value="ĐĂNG NHẬP">
				</fieldset>
			</form>
		</div>
		
	</content>
	<footer>Bui Hoang Long - 99096 - CNT63DH</footer>
</body>
</html>