<?php
include 'connection.php';
$id = $_GET['id'];
$sql1 = "delete from tongketnam where id = '$id'";
$stmt = $conn->prepare($sql1);
$query = $stmt->execute();
header("location:index.php");
?>