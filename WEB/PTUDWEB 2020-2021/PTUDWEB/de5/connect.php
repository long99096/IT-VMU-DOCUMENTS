<?php
$conn = "mysql:host=localhost;dbname=dh";
$user = 'student';
$pass = '123456';
$pdo = new PDO($conn, $user, $pass);
if (!$pdo) {
    echo 'Ket noi that bai';
}
?>