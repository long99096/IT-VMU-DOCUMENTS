<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('location:signin.php');
}
include 'connect.php';
if($con){
	echo "trindshfsdf";
}
$IDNS=$_GET['idns'];
#create VIEW hienthi2 as
#select nhansu.hovaten as TenNS , thannhan.id as IDTN , thannhan.ten , thannhan.quanhe,thannhan.dienthoai from thannhan , nhansu 
#WHERE nhansu.id = thannhan.nhansu_id;
if(empty($_POST['submit'])){
	$sql= "SELECT * FROM hienthi2 where IDNS='$IDNS'";
	$stmt= $con->prepare($sql);
	$query= $stmt->execute();
	$result=array();
	while($row=$stmt->fetch(PDO::FETCH_ASSOC)){
		$result[]=$row;
	}
	echo " lon";
}
else{
	$timkiem=$_POST['timkiem'];
	echo $timkiem;
	$sql="SELECT * FROM hienthi2 where hovaten like '%$timkiem%'";
	$stmt= $con->prepare($sql);
	$query=$stmt->execute();
	$result=array();
	while ($row=$stmt->fetch(PDO::FETCH_ASSOC)) {
		$result[]=$row;
	}
	echo "lin";

}
echo " dsfs";

?>
<!DOCTYPE html>
<html>
<head>
	<title>Danh sách vận đơn</title>
	 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="style.css">
</head>
<body>
	<header>
		<div class="logo">
            <img style="    height: 80px; width: 80px;"
                src="https://intphcm.com/data/upload/logo-the-thao-dep.jpg" alt=""> Quản lí nhân sự
        </div>
	</header>
	<content>
		<div class="container">
			<ul class="nav">
				<li class="nav-item">
					<a class="nav-link" href="index.php">Trang chủ</a>
				</li>
				<li class="nav-item">
                    <a href="list.php" class="nav-link">Danh sách nhân sự</a>
                </li>
                 <li class="nav-item">
                    <a href="1.png" class="nav-link">Ảnh câu 1</a>
                </li>
                <li class="nav-item">
                    <a href="out.php" class="nav-link">Đăng xuất</a>
                </li>				
			</ul>
			<br>

			<form method="post">
				<label>Tìm Kiếm</label>
				<input type="text" name="timkiem" placeholder="Nhập họ tên nhân viên">
				<input type="submit" name="submit" value="Tìm kiếm">
			</form>
			<br>
            <a href="add.php?idns=<?php echo $IDNS; ?>"
           class='btn btn-primary'>Thêm thân nhân</a>
            <br>
            <br>
			<table class="table table-inverse">
				<thead>
					<tr>
						<th>Mã thân nhân</th>
						<th>Tên nhân sự</th>
						<th>Tên thân nhân</th>
						<th>quan hệ</th>
						<th>Điện thoại</th>
					</tr>
				</thead>
				<tbody>
					<?php
					foreach ($result as $items):?>
					<tr>
						<td><?php echo $items['IDTN'] ?></td>
						<td><?php echo $items['TenNS'] ?></td>
						<td><?php echo $items['ten'] ?></td>
						<td><?php echo $items['quanhe'] ?></td>
						<td><?php echo $items['dienthoai'] ?></td>
											
					</tr>
					<?php endforeach ?>
				</tbody>
			</table>
		</div>

	</content>
	<footer>Trịnh Tiến Lộc-83785</footer>
</body>
</html>