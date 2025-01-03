<?php
	include('connect.php');
	$sql = "SELECT * FROM nhanvien";
	$stmt = $conn->prepare($sql);
	$query = $stmt->execute();

	$result = array();
	while($row = $stmt->fetch(PDO::FETCH_ASSOC)){
		$result[] = $row;
	}

	if(!empty($_POST['submit'])){
		if(isset($_POST['idvandon']) && isset($_POST['nhanvien']) && isset($_POST['trangthai']) && isset($_POST['nguoinhan']) && isset($_POST['dienthoai']) && isset($_POST['diachi']) && isset($_POST['date']) && isset($_POST['ghichu'])){
			$idvandon = $_POST['idvandon'];
			$nhanvien = $_POST['nhanvien'];
			$trangthai = $_POST['trangthai'];
			$nguoinhan = $_POST['nguoinhan'];
			$dienthoai = $_POST['dienthoai'];
			$diachi = $_POST['diachi'];
			$date = $_POST['date']; 
			$ghichu = $_POST['ghichu'];

			$sql = "INSERT INTO vandon VALUES ('$idvandon', '$nhanvien', '$trangthai', '$nguoinhan', '$dienthoai', '$diachi', '$date', '$ghichu')";
			$stmt = $conn->prepare($sql);
			$query = $stmt->execute();

			if($query) {
				header("Location: list.php");
				exit();
			}
		}
	}
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Quản lý vận đơn Long</title>
</head>
<body>
	<header>Quản lý vận đơn</header>
	<content>
		<p>Test</p>
		<ul>
			<li><a href="admin.php">Trang chủ</a></li>
			<li><a href="list.php">Vận đơn</a></li>
		</ul>

		

		<form method="post">
			<fieldset class="form-group">
				<label for="formGroupExampleInput">ID Vận đơn</label>
				<input type="text" class="form-control" name="idvandon" placeholder="Nhập ID Vận đơn">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput2">Nhân viên</label>
				<select class="form-control" name="nhanvien" placeholder="Chọn Nhân viên">
					<?php foreach ($result as $items): ?>
						<option value="<?php echo $items['id']; ?>"><?php echo $items['hoten']; ?></option>
					<?php endforeach; ?> 
				</select>
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput">Trạng thái</label>
				<input type="text" class="form-control" name="trangthai" placeholder="Nhập trạng thái">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput2">Người nhận</label>
				<input type="text" class="form-control" name="nguoinhan" placeholder="Nhập người nhận">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput">Điện thoại</label>
				<input type="text" class="form-control" name="dienthoai" placeholder="Nhập điện thoại">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput2">Địa chỉ</label>
				<input type="text" class="form-control" name="diachi" placeholder="Nhập địa chỉ">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput">Ngày</label>
				<input type="date" class="form-control" name="date">
			</fieldset>
			<fieldset class="form-group">
				<label for="formGroupExampleInput2">Ghi chú</label>
				<input type="text" class="form-control" name="ghichu" placeholder="Ghi chú">
			</fieldset>
			<fieldset class="form-group">
				<input type="submit" class="form-control" name="submit" value="LƯU">
			</fieldset>
		</form>
	</content>
	<footer>Bùi Hoàng Long - 99096 - CNT63DH</footer>
</body>
</html>
