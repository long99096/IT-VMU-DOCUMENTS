<?php
    $conn = new PDO('mysql:host=localhost;dbname=hocsinh', 'root', '');
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $hocsinh_id = $_POST['hocsinh_id'] ?? '';
    $namhoc = $_POST['namhoc'] ?? '';
    $nhanxetchung = $_POST['nhanxetchung'] ?? '';
    $uudiem = $_POST['uudiem'] ?? '';
    $cackhacphuc = $_POST['cackhacphuc'] ?? '';
    $duoclenlop = $_POST['duoclenlop'] ?? 0;
    
        $stmt = $conn->prepare("INSERT INTO tongketnam (hocsinh_id, namhoc, nhanxetchung, uudiem, cackhacphuc, duoclenlop) 
                                VALUES (:hocsinh_id, :namhoc, :nhanxetchung, :uudiem, :cackhacphuc, :duoclenlop)");
        $stmt->execute([
            ':hocsinh_id' => $hocsinh_id,
            ':namhoc' => $namhoc,
            ':nhanxetchung' => $nhanxetchung,
            ':uudiem' => $uudiem,
            ':cackhacphuc' => $cackhacphuc,
            ':duoclenlop' => $duoclenlop
        ]);
        $message = "Thêm học sinh thành công!";
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Thêm học sinh</title>
</head>
<body>
    <h2>Thêm mới học sinh</h2>

    <form method="POST">
        <label for="hocsinh_id">Mã học sinh:</label>
        <input type="text" name="hocsinh_id" required><br><br>

        <label for="namhoc">Năm học:</label>
        <input type="text" name="namhoc" required><br><br>

        <label for="nhanxetchung">Nhận xét chung:</label>
        <textarea name="nhanxetchung"></textarea><br><br>

        <label for="uudiem">Ưu điểm:</label>
        <textarea name="uudiem"></textarea><br><br>

        <label for="cackhacphuc">Cách khắc phục:</label>
        <textarea name="cackhacphuc"></textarea><br><br>

        <label for="duoclenlop">Được lên lớp:</label>
        <select name="duoclenlop">
            <option value="1">Có</option>
            <option value="0">Không</option>
        </select><br><br>

        <button type="submit">Thêm học sinh</button>
    </form>

    <br>
    <a href="index.php">Quay lại danh sách học sinh</a>
</body>
</html>
