<?php
session_start();
if (!isset($_SESSION['tendaydu'])) {
    header('location:login.php');
    exit();
} 

include('connect.php');

if (empty($_POST['timkiem'])) {
    $sql = "select * from sanpham";
    $stmt = $conn->prepare($sql);
    $query = $stmt->execute();

    $result = array();
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        $result[] = $row;
    }
} else {
    $timkiem = $_POST['timkiem'];
    $sql = "select * from sanpham where ten like '%$timkiem%'";
    $stmt = $conn->prepare($sql);
    $query = $stmt->execute();

    $result = array();
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        $result[] = $row;
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Quan ly san pham Long</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        header {
            background-color: #007bff;
            color: white;
            text-align: center;
        }
    </style>
</head>
<body>
    <header>
      <img style="width:100px" src="../sena.jpg" alt="">
      <h1>Quan ly san pham</h1>
    </header>
    <content>
        <ul class="nav">
            <li><a href="add.php" class="nav-link">Them</a></li>
            <li><a href="logout.php" class="nav-link">Dang xuat</a></li>
        </ul>

        <form method="post">
            <div>
                <input type="text" name="timkiem" placeholder="Nhap ma tim kiem">
                <input type="submit" name="submit" value="Tim kiem">
            </div>
        </form>

        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Ten</th>
                    <th>Anh</th>
                    <th>Ngay san xuat</th>
                    <th>Gia</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <?php foreach ($result as $items): ?>
                <tr>
                    <td><?php echo $items['id']; ?></td>
                    <td><?php echo $items['ten']; ?></td>
                    <td><img style="width: 100px" src="../<?php echo $items['anh']; ?>" alt=""></td>
                    <td><?php echo $items['ngaysanxuat']; ?></td>
                    <td><?php echo $items['gia']; ?></td>
                    <td>
                        <a href="edit.php?ID=<?= $items['id'] ?>">Edit</a>
                        <a href="delete.php?ID=<?= $items['id'] ?>">Delete</a>
                    </td>
                </tr>
                <?php endforeach ?>
            </tbody>
        </table>
    </content>
    <footer style="text-align: center;">
        ...
        <br>
        Nguoi dung : <?php echo $_SESSION['tendaydu']; ?>
    </footer>
</body>
</html>
