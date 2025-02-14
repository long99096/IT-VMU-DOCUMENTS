<?php
include('connect.php');

if(!empty($_POST['submit'])){
    if(isset($_POST['username']) && isset($_POST['password'])){
        $username = $_POST['username'];
        $password = md5($_POST['password']);  // Mã hóa mật khẩu bằng md5

        $sql1 = "UPDATE user SET matkhau = :password WHERE username = :username";
        $stmt = $conn->prepare($sql1);
        
        // Gắn giá trị vào tham số để tránh SQL injection
        $stmt->bindParam(':username', $username, PDO::PARAM_STR);
        $stmt->bindParam(':password', $password, PDO::PARAM_STR);

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
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css">
</head>

<body>
    <div class="container">
        <h1 class="text-center">Đổi mật khẩu</h1>
        <form method="POST">
            <fieldset class="form-group">
                <input name="username" type="text" placeholder="Nhập tên đăng" class="form-control">
            </fieldset>
            <br>
            <fieldset class="form-group">
                <input name="password" type="password" placeholder="Nhập mật khẩu mới" class=" form-control">
            </fieldset>
            <br>
            <fieldset class="form-group">
                <input type="submit" name="submit" class="form-control btn-success" value="Save"></input>
            </fieldset>
            <br>
            <fieldset class="form-group">
                <input type="button" name="back" value="Back" onclick="window.location='login.php'"
                    class="form-control btn-success"></input>
            </fieldset>
        </form>

    </div>
</body>