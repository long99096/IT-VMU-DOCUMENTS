<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('location:signin.php');
}
?>
<?php
require_once 'connect.php';
var_dump($_POST);
$clb_id = $_POST['clb_id'];
$tungay = $_POST['tungay'];
$denngay = $_POST['denngay'];
$muctieu = $_POST['muctieu'];

$sql = "INSERT INTO hoatdong(clbtochuc_id,tungay,denngay,muctieu) VALUES(
    '$clb_id', '$tungay', '$denngay', '$muctieu')";
$stmt = $pdo->prepare($sql);
$row = $stmt->execute();

if ($row) {
    header("Location:" . 'themhoatdong.php?id=' . $clb_id);
}
?>