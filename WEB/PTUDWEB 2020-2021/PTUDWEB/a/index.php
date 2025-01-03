<?php
	session_start();
	if(!isset($_SESSION['username'])){
		header('location:signin.php');
	}
?>
<!DOCTYPE html>
<html>
<head>
	<title>Bùi Thị Hồng Nhung - 84322</title>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<script type="text/javascript" src="js/jquery-3.5.1.slim.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
	<header>QUẢN LÝ VẬN ĐƠN</header>
	<content>
		<div class="container">
					<ul class="nav">
						<li class="nav-item">
							<a class="nav-link" href="index.php">Trang chủ</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="list.php">Danh sách vận đơn</a>
						</li>
						<li class="nav-item">
							<a class="nav-link" href="signout.php">Đăng xuất</a>
						</li>
						<li class="nav-item">
							XIN CHÀO <?php echo($_SESSION['username']) ?>
							Đăng nhập vào lúc <?php echo $_SESSION['datetime']?>
						</li>
					</ul>
			
		</div>
		
	</content>
	<footer>Bùi Thị Hồng Nhung - 84322</footer>
</body>
</html>
