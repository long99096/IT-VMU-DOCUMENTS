<?php
include 'connect.php';
if(isset($_GET['id'])){
    $id=$_GET['id'];
    $sql="DELETE FROM nhansu WHERE id=$id";
    if($conn->query($sql)===TRUE){
        header("location: index.php");
        exit();
    }
    $conn->close();
}
else{
    header("location: index.php");
    exit();
}
?>