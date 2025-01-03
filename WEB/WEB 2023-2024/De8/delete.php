<?php
include 'connect.php';
if(isset($_GET['id'])){
    $id=$_GET['id'];
    $sql= "DELETE FROM sach WHERE id='$id'";
    if($conn->query($sql)===TRUE){
        header('location:index.php');
        exit();
    }
}
else{
    header('location:index.php');
    exit();
}
?>