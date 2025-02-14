<?php
    session_start(); 
    if(!isset($_SESSION['tendaydu'])){
        header('location: login.php');
    }


    include('connect.php');

    if(!empty($_POST['search'])){
        $search = $_POST['search'];
        $sql1 = "SELECT * FROM tongketnam WHERE id LIKE '%$search%'";
        $stmt1 = $conn->prepare($sql1);
        $query1 = $stmt1->execute();
        $result = array();
        while($row = $stmt1->fetch(PDO::FETCH_ASSOC)){
            $result[] = $row;
        }//Tìm kiếm 
    }
    else{
        $sql = "SELECT * FROM tongketnam";
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
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>KTTC 2</title>
</head>

<body>
    <header>
        
        <div class="tieude">
            <h1>Tong Ket</h1>
        </div>
    </header>
    <content>
        <div class="container">
            <ul class="nav justify-content-center" style="background-color: #f1f1f1">
                <li class="nav-item">
                    <a class="nav-link" href="add.php">Thêm </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="login.php">Đăng xuất</a>
                </li>
            </ul>
            <br>
            <form method="post">

                <div class="container d-flex justify-content-between">
                    <input type="text" name="search" placeholder="Nhap ma hoc sinh" class="form-control"
                        style="width: 74%">
                    <input type="submit" name="submit" class="form-control" value="Tim kiem" style="width: 25%">
                </div>
            </form>
            <br>
            <table class="table">
                <thread>
                    <tr style="background-color: #d2d2d2">
                        <th>id</th>
                        <th>Hoc sinh</th>
                        <th>Nam hoc</th>
                        <th>Nhan xet chung</th>
                        <th>Uu diem</th>
                        <th>Cach Khac Phuc</th>
                        <th>Duoc len lop</th>
                        <th colspan="2">Thao tac</th>
                    </tr>
                </thread>
                <tbody>
                    <?php foreach($result as $item) :?>
                    <tr>
                        <td><?php echo $item['id']?></td>
                        <td><?php echo $item['hocsinh_id']?></td>
                        <td><?php echo $item['namhoc']?></td>
                        <td><?php echo $item['nhanxetchung']?></td>
                        <td><?php echo $item['uudiem']?></td>
                        <td><?php echo $item['cachkhacphuc']?></td>
                        <td><?php echo $item['duoclenlop']?></td>
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