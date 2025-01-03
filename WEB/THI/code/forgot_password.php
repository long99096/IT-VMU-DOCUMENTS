<?php
session_start();
unset($_SESSION['tendaydu']); 

include('connect.php'); 

if (!empty($_POST['submit'])) {
    if (isset($_POST['username']) && isset($_POST['matkhau'])) { 
       
        $username = $_POST['username'];
        $password = $_POST['matkhau'];

 
        $sql = "UPDATE user SET matkhau = '$password' WHERE username = '$username'";
        $stmt = $conn->prepare($sql);
	    $query = $stmt->execute();
        
        if($query){
            header("location:login.php");
            exit();
        } else {
            echo "Thay đổi mật khẩu thất bại, vui lòng thử lại";
        }
    }
}    
?>

<!DOCTYPE html> 
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <title>Đăng nhập</title>
</head>

<body>
    <div class="container">
        <h1 class="text-center">Đổi mật khẩu</h1>
        <form method="POST">
            <fieldset>
                <input name="username" type="text" placeholder="Nhập tên đăng nhập" class="form-control">
            </fieldset>
            <br>
            <fieldset>
                <input name="matkhau" type="text" placeholder="Nhập mật khẩu" class="form-control">
            </fieldset>
            <br>
            <fieldset class="form-group">
                <input type="submit" name="submit" class="form-control btn btn-outline-secondary" value="LƯU"></input>
            </fieldset>
        </form>
    </div>
</body>

</html>
