<?php
session_start();

if (!isset($_SESSION['tendaydu'])) {
    header('location: login.php');
}

include('connect.php');

if (!empty($_POST['submit'])) {
    if (isset($_POST['ten']) && isset($_POST['anh']) && isset($_POST['ngaysanxuat']) && isset($_POST['gia'])) {
        $ten = $_POST['ten'];
        $anh = $_POST['anh'];
        $ngaysanxuat = $_POST['ngaysanxuat'];
        $gia = $_POST['gia'];
        
        $sql = "INSERT INTO sanpham (ten, anh, ngaysanxuat, gia) VALUES('$ten', '$anh', '$ngaysanxuat', '$gia')";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();
        
        if ($query) {
            header("location:admin.php");
        } else {
            echo("Thêm thất bại, vui lòng thử lại");
        }
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    <title>Thêm sản phẩm</title>
</head>
<body>
    <div class="container">
        <h2>Thêm sản phẩm</h2>
        <form method="post">
            <fieldset>
                <label>Ten</label>
                <input type="text" class="form-control" name="ten" placeholder="Nhap ten">
            </fieldset>
            <fieldset>
                <label>Link anh</label>
                <input type="text" class="form-control" name="anh" placeholder="Nhap link anh">
            </fieldset>
            <fieldset>
                <label>Ngay san xuat</label>
                <input type="date" class="form-control" name="ngaysanxuat" placeholder="Nhap ngay san xuat">
            </fieldset>
            <fieldset>
                <label>Gia</label>
                <input type="text" class="form-control" name="gia" placeholder="Nhap gia">
            </fieldset>
            <fieldset>
            <input type="submit" class="form-control btn btn-primary" name="submit" value="LƯU">
            </fieldset>
        </form>
    </div>
</body>
</html>
