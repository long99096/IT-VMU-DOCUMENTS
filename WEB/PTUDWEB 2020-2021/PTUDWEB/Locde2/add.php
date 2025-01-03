<?php 
include 'connect.php';
if(isset($_GET['idns'])){

}


$sql1= "SELECT * FROM hienthi2 where IDNS='$IDNS'";
    $stmt1= $con->prepare($sql1);
    $query1= $stmt1->execute();
    $result1=array();
    while($row=$stmt1->fetch(PDO::FETCH_ASSOC)){
        $result1[]=$row;
    }
if(!empty($_POST['submit'])){
	if(isset($_POST['sdt']) && isset($_POST['tenTN']) && isset($_POST['quanhe'])){
		$tenTN=$_POST['tenTN'];
		$quanhe=$_POST['quanhe'];
		$sdt=$_POST['sdt'];		
		$sql = "INSERT INTO thannhan(nhansu_id,ten,quanhe,dienthoai) values('$IDNS','$tenTN','$quanhe','$sdt')";
		var_dump($sql);
		$stmt=$con->prepare($sql);
		$query=$stmt->execute();
		if($query){
			header('location:add.php');
		}
		else{
           echo "Thêm dữ liệu thất bại";
		}

	}
}
?>
<!DOCTYPE html>
<html>
<head>
	<title>Thêm vận đơn</title>
	 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="style.css">
</head>
<body>
	<header>Quản lí vận đơn
	</header>
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
                    <a href="add_vandon.php" class="nav-link">thêm</a>
                </li>
			</ul>
			 <form method="post">
                <fieldset class="form-group">
                    <label style="float: left;" for="formGroupexampleInput">Tên thân nhân</label>
                    <input type="text" class="form-control" name="tenTN" placeholder="Nhập tên">
                </fieldset>                
                <fieldset class="form-group">
                    <label style="float: left;" for="formGroupexampleInput">quan hệ</label>
                    <input type="text" class="form-control" name="quanhe" placeholder="Nhập quan hệ">
                </fieldset>
                 <fieldset class="form-group">
                    <label style="float: left;" for="formGroupexampleInput">điện thoại</label>
                    <input type="text" class="form-control" name="sdt" placeholder="Nhập số điện thoại">
                </fieldset>
                <fieldset class="form-group">                   
                    <input type="submit" class="form-control btn btn-primary" name="submit" placeholder="LƯU">
                </fieldset>
                
            </form>
            <br>
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
                    foreach ($result1 as $items):?>
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
</body>
</html>