<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quản lý học sinh</title>
</head>
<body>
    <header>
        <h1>Quản lý học sinh</h1>
    </header>
    <content>
<?php
include 'connection.php';
    $stmt = $conn->prepare("SELECT * FROM tongketnam");
    $stmt->execute();
    $hocsinhList = $stmt->fetchAll(PDO::FETCH_ASSOC);
?>

    <h2>Danh sách học sinh</h2>
    <table>
        <tr>
            <th>ID</th>
            <th>Mã học sinh</th>
            <th>Năm học</th>
            <th>Nhận xét chung</th>
            <th>Ưu điểm</th>
            <th>Cách khắc phục</th>
            <th>Được lên lớp</th>
            <th>Hành động</th>
        </tr>
        <?php foreach ($hocsinhList as $hocsinh): ?>
        <tr>
            <td><?= $hocsinh['id'] ?></td>
            <td><?= $hocsinh['hocsinh_id'] ?></td>
            <td><?= $hocsinh['namhoc'] ?></td>
            <td><?= $hocsinh['nhanxetchung'] ?></td>
            <td><?= $hocsinh['uudiem'] ?></td>
            <td><?= $hocsinh['cackhacphuc'] ?></td>
            <td><?= $hocsinh['duoclenlop'] ? "Có" : "Không" ?></td>
            <td>
                <a href="sua.php?id=<?= $hocsinh['id'] ?>">Sửa</a> |
                <a href="xoa.php?id=<?= $hocsinh['id'] ?>" onclick="return confirm('Bạn có chắc chắn muốn xóa?')">Xóa</a>
            </td>
        </tr>
        <?php endforeach; ?>
    </table>
    <br>
    <a href="themhocsinh.php">Tạo mới học sinh</a>
</content>

    <footer>
        <p>Mã SV: 99096 | Tên SV: Bui Hoang Long | Lớp: CNT63DH</p>
    </footer>
</body>
</html>
