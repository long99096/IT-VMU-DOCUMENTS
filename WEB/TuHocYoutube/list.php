<?php
session_start();
if(!isset($_SESSION['tendaydu'])){
	header('location:login.php');
}
	include('connect.php');
	if(empty($_POST['submit'])){
		$sql = "select * from hienthi";
	$stmt = $conn->prepare($sql);
	$query = $stmt->execute();

	$result = array();
	while($row = $stmt->fetch(PDO::FETCH_ASSOC)){
		$result[] = $row;
	}
	}
	else{
		$timkiem = $_POST['timkiem'];
		$sql = "select * from hienthi where nguoinhan like '%$timkiem%'";
	$stmt = $conn->prepare($sql);
	$query = $stmt->execute();

	$result = array();
	while($row = $stmt->fetch(PDO::FETCH_ASSOC)){
		$result[] = $row;
	}
	}


?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Quan ly van don Long</title>
</head>
<body>
	<header>Quan ly van don</header>
	<content>
		<p>Test</p>
		<ul>
			<li><a href="admin.php">Trang chu</a></li>
			<li><a href="list.php">Van don</a></li>
			<li><a href="add.php">Them</a> </li>
		</ul>
		
		<form method="post">
			<label>Tìm kiếm</label>
			<input type="text" name="timkiem">
			<input type="submit" name="submit" value="Tìm Kiếm">
		</form>

		<table>
			<thead>
				<tr>
					<th>Ma van don</th>
				<th>Nguoi phu trach</th>
				<th>Nguoi nhan</th>
				<th>Dia chi</th>
				<th>Ghi chu</th>
				<th>Hanh dong</th>
				</tr>
			</thead>
			<tbody>
				<?php foreach($result as $items):?>
				<tr>
					<td><?php echo $items['id'];?></td>
					<td><?php echo $items['hoten'];?></td>
					<td><?php echo $items['nguoinhan'];?></td>
					<td><?php echo $items['diachi'];?></td>
					<td><?php echo $items['ghichu'];?></td>
					<td> <input type="button" name="edit" value="edit" class="btn-danger"
                                onclick="window.location= 'edit.php?ID=<?= $items['id']?>'"></td>
                        <td><input type="button" name="delete" value="delete" class="btn-danger"
                                onclick="window.location= 'delete.php?ID=<?= $items['id']?>'"></td>
				</tr>
			<?php endforeach?>
			</tbody>
		</table>
	</content>
	<footer>Bui Hoang Long - 99096 - CNT63DH</footer>
</body>
</html>