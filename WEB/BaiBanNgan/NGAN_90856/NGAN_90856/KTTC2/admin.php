<?php
    session_start(); 
    if(!isset($_SESSION['tendaydu'])){
        header('location: login.php');
    }//ngăn chặn truy cập từ bên ngoài khi chưa đăng nhập


    include('connect.php');

    if(!empty($_POST['search'])){
        $search = $_POST['search'];
        $sql1 = "SELECT * FROM vandon WHERE nhanvien_id LIKE '%$search%'";
        $stmt1 = $conn->prepare($sql1);
        $query1 = $stmt1->execute();
        $result = array();
        while($row = $stmt1->fetch(PDO::FETCH_ASSOC)){
            $result[] = $row;
        }//Tìm kiếm 
    }
    else{
        $sql = "SELECT * FROM vandon";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();
        $result = array();
        while($row = $stmt->fetch(PDO::FETCH_ASSOC)){
            $result[] = $row;
        }
    }//hiện thị tất cả 
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>KTTC 2</title>
</head>

<body>
    <header>
        <div class="anh">
            <img src="logo.jpg" alt="logo" class="logo">
        </div>
        <div class="tieude">
            <h1>Quản Lý Vận Đơn</h1>
        </div>
    </header>
    <content>
        <div class="container">
            <ul class="nav justify-content-center" style="background-color: #f1f1f1">
                <li class="nav-item">
                    <a class="nav-link" href="add.php">Thêm Vận Đơn</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="list.php">Danh Sách</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="login.php">Đăng xuất</a>
                </li>
            </ul>
            <br>
            <form method="post">

                <div class="container d-flex justify-content-between">
                    <input type="text" name="search" placeholder="Nhap ma nhan vien" class="form-control"
                        style="width: 74%">
                    <input type="submit" name="submit" class="form-control" value="Tim kiem" style="width: 25%">
                </div>
            </form>
            <br>
            <table class="table">
                <thread>
                    <tr style="background-color: pink">
                        <th>Ma don hang</th>
                        <th>Ma nhan vien</th>
                        <th>Nguoi nhan</th>
                        <th>Dien thoai</th>
                        <th>Dia chi</th>
                        <th>Ngay giao hang</th>
                        <th>Ghi chú</th>
                        <th colspan="2">Thao tac</th>
                    </tr>
                </thread>
                <tbody>
                    <?php foreach($result as $item) :?>
                    <tr>
                        <td><?php echo $item['id']?></td>
                        <td><?php echo $item['nhanvien_id']?></td>
                        <td><?php echo $item['nguoinhan']?></td>
                        <td><?php echo $item['dienthoai']?></td>
                        <td><?php echo $item['diachi']?></td>
                        <td><?php echo $item['ngaygiaohang']?></td>
                        <td><?php echo $item['ghichu']?></td>
                        <td> <input type="button" name="edit" value="edit" class="btn-danger"
                                onclick="window.location= 'edit.php?ID=<?= $item['id']?>'"></td>
                        <td><input type="button" name="delete" value="delete" class="btn-danger"
                                onclick="window.location= 'delete.php?ID=<?= $item['id']?>'"></td>
                    </tr>
                    <?php endforeach; ?>
                </tbody>
            </table>
        </div>
    </content>
    <footer>
        <label>Pham Thi Ngan_90856</label><br>
        <label>Hi <?php echo $_SESSION['tendaydu']?></label>
    </footer>
</body>

</html>