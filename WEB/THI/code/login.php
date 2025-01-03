<?php
session_start();
unset($_SESSION['tendaydu']); 

include('connect.php'); 

if (!empty($_POST['submit'])) {
    if (isset($_POST['username']) && isset($_POST['matkhau'])) { 
       
        $username = $_POST['username'];
        $password = $_POST['matkhau'];

        $sql = "SELECT * FROM user WHERE username = '$username' AND matkhau = '$password'";
        $stmt = $conn->prepare($sql);
	    $query = $stmt->execute();
        $row = $stmt->fetch(PDO::FETCH_ASSOC);
	    if(!$row){
		    echo "Dang nhap that bai";
	    }
	    else{
		    $_SESSION['tendaydu'] = $row['tendaydu'];
            //$_SESSION['tendaydu'] = $username;
		    header("location:admin.php");
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
        <h1 class="text-center">Đăng nhập</h1>
        <form method="POST">
            <fieldset>
                <input name="username" type="text" placeholder="Nhập tên đăng nhập" class="form-control">
            </fieldset>
            <br>
            <fieldset>
                <input name="matkhau" type="text" placeholder="Nhập mật khẩu" class="form-control">
            </fieldset>
            <br>
            <fieldset>
                <input type="submit" name="submit" class="form-control btn btn-outline-secondary" value="Đăng nhập">
            </fieldset>
            <br>
            <fieldset>
                <input type="button" name="forgot_pass" value="Quên mật khẩu"
                    onclick="window.location='forgot_password.php'" class="form-control btn btn-outline-secondary">
            </fieldset>
        </form>
    </div>
</body>

</html>
