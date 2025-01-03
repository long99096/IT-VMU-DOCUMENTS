<?php 
     include('connect.php');
     if(!empty($_GET['ID'])){
        $ID =$_GET['ID'];
        $sql = "DELETE FROM vandon WHERE id = '$ID'";
        $stmt = $conn->prepare($sql);
        $query = $stmt->execute();
        if($query){
            header('location: list.php');
            exit();
        }
        else{
            echo "xoa that bai";
        }
     }
     else{
        echo "khong tim thay ID";
     }
?>