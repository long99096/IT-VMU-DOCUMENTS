<?php 
     include('connect.php');
     if(!empty($_GET['ID'])){
        $ID =$_GET['ID'];
        $sql = "DELETE FROM sanpham WHERE id = '$ID'";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();
        if($query){
            header('location: admin.php');
            exit();
        }
     }
?>