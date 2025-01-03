<?php

include('connection.php');


$id = $_GET['id'];

$sql = "SELECT * FROM tongketnam WHERE id = :id";
$stmt = $conn->prepare($sql);
$stmt->execute([':id' => $id]);
$result = $stmt->fetch(PDO::FETCH_ASSOC);

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['id'], $_POST['namhoc'], $_POST['nhanxetchung'], $_POST['uudiem'], $_POST['cackhacphuc'], $_POST['duoclenlop'])) {
        $id = $_POST['id'];
        $namhoc = $_POST['namhoc'];
        $nhanxetchung = $_POST['nhanxetchung'];
        $uudiem = $_POST['uudiem'];
        $cackhacphuc = $_POST['cackhacphuc'];
        $duoclenlop = $_POST['duoclenlop'];

        $sql_update = "UPDATE tongketnam SET 
                        namhoc = :namhoc, 
                        nhanxetchung = :nhanxetchung, 
                        uudiem = :uudiem, 
                        cackhacphuc = :cackhacphuc, 
                        duoclenlop = :duoclenlop 
                      WHERE id = :id";

        $stmt = $conn->prepare($sql_update);
        $query = $stmt->execute([
            ':id' => $id,
            ':namhoc' => $namhoc,
            ':nhanxetchung' => $nhanxetchung,
            ':uudiem' => $uudiem,
            ':cackhacphuc' => $cackhacphuc,
            ':duoclenlop' => $duoclenlop
        ]);

        if ($query) {
            header("Location: index.php");
            exit;
        } else {
            echo "Cập nhật thất bại, vui lòng thử lại!";
        }
    }
}
?>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sửa thông tin học sinh</title>
</head>
<body>
    <header>
        <h1>Sửa thông tin học sinh</h1>
    </header>

    <div class="container">
        <form action="sua.php?id=<?php echo $result['id']; ?>" method="POST">
            <table>
                <tr>
                    <td>ID:</td>
                    <td><input type="text" name="id" value="<?php echo $result['id']; ?>" readonly></td>
                </tr>
                <tr>
                    <td>Năm học:</td>
                    <td><input type="text" name="namhoc" value="<?php echo $result['namhoc']; ?>"></td>
                </tr>
                <tr>
                    <td>Nhận xét chung:</td>
                    <td><input type="text" name="nhanxetchung" value="<?php echo $result['nhanxetchung']; ?>"></td>
                </tr>
                <tr>
                    <td>Ưu điểm:</td>
                    <td><input type="text" name="uudiem" value="<?php echo $result['uudiem']; ?>"></td>
                </tr>
                <tr>
                    <td>Cách khắc phục:</td>
                    <td><input type="text" name="cackhacphuc" value="<?php echo $result['cackhacphuc']; ?>"></td>
                </tr>
                <tr>
                    <td>Được lên lớp:</td>
                    <td><input type="number" name="duoclenlop" value="<?php echo $result['duoclenlop']; ?>"></td>
                </tr>
            </table>
            <br>
            <button type="submit" name="submit">Lưu</button>
        </form>

        <br>
        <a href="index.php">Quay lại danh sách học sinh</a>
    </div>
</body>
</html>
