<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('location:signin.php');
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>

<body>
    <header>Quản Lý nhân sự</header>
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

            <p>Đây là trang chủ</p>

        </div>

    </content>
    <footer>
        Trịnh Tiến Lộc - 83785
    </footer>
</body>

</html>