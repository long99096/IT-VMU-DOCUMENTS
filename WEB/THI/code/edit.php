<?php
session_start();

if (!isset($_SESSION['tendaydu'])) {
    header('location: login.php');
}

include('connect.php');

if (!empty($_GET['ID'])) {
    $ID = $_GET['ID'];
    $sql1 = "SELECT * FROM sanpham WHERE id = '$ID'";
    $stmt1 = $conn->prepare($sql1);
    $query1 = $stmt1->execute();
    $item = $stmt1->fetch(PDO::FETCH_ASSOC);
}

if (!empty($_POST['submit'])) {
    if (isset($_POST['ten']) && isset($_POST['anh']) && isset($_POST['ngaysanxuat']) && isset($_POST['gia'])) {
        $ten = $_POST['ten'];
        $anh = $_POST['anh'];
        $ngaysanxuat = $_POST['ngaysanxuat'];
        $gia = $_POST['gia'];

        $sql = "UPDATE sanpham 
                SET ten = '$ten', anh = '$anh', ngaysanxuat = '$ngaysanxuat', gia = '$gia' 
                WHERE id = '$ID'";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();

        if ($query) {
            header("location:admin.php");
        } else {
            echo("Cập nhật thất bại, vui lòng thử lại");
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
    <title>Cập nhật sản phẩm</title>
</head>
<body>
    <div class="container">
        <h2>Cập nhật sản phẩm</h2>
        <form method="post">
            <fieldset>
                <label for="ten">Tên sản phẩm</label>
                <input type="text" class="form-control" name="ten" id="ten" placeholder="Nhập tên sản phẩm" value="<?php echo $item['ten']; ?>">
            </fieldset>
            <fieldset>
                <label for="anh">Link ảnh</label>
                <input type="text" class="form-control" name="anh" id="anh" placeholder="Nhập link ảnh" value="<?php echo $item['anh']; ?>">
            </fieldset>
            <fieldset>
                <label for="ngaysanxuat">Ngày sản xuất</label>
                <input type="date" class="form-control" name="ngaysanxuat" id="ngaysanxuat" placeholder="Nhập ngày sản xuất" value="<?php echo $item['ngaysanxuat']; ?>">
            </fieldset>
            <fieldset>
                <label for="gia">Giá</label>
                <input type="text" class="form-control" name="gia" id="gia" placeholder="Nhập giá sản phẩm" value="<?php echo $item['gia']; ?>">
            </fieldset>
            <fieldset>
                <input type="submit" class="form-control btn btn-primary" name="submit" value="LƯU">
            </fieldset>
        </form>
    </div>
</body>
</html>
