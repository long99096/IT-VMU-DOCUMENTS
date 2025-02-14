<!DOCTYPE html>
<html lang="en">
<?php 
    session_start();
    //if(!isset($_SESSION['tendaydu'])){
        //header('location: login.php');
    //}
    include('connect.php');
    if(!empty($_GET['ID'])){
        $ID = $_GET['ID'];
        $sql1 = "SELECT * FROM tongketnam WHERE ID = '$ID'";
        $stmt1 = $conn->prepare($sql1);
        $query1 = $stmt1->execute();
        $item = $stmt1->fetch(PDO:: FETCH_ASSOC);
    }

    if(!empty($_POST['submit'])){
        if(isset($_POST['hocsinh_id']) && isset($_POST['namhoc']) && isset($_POST['nhanxetchung']) && isset($_POST['uudiem']) && isset($_POST['cachkhacphuc']) && isset($_POST['duoclenlop'])){
            $hocsinh_id = $_POST['hocsinh_id'];
            $namhoc = $_POST['namhoc'];
            $nhanxetchung = $_POST['nhanxetchung'];
            $uudiem = $_POST['uudiem'];
            $cachkhacphuc = $_POST['cachkhacphuc'];
            $duoclenlop = $_POST['duoclenlop'];
            
            $sql = "UPDATE tongketnam SET hocsinh_id='$hocsinh_id', namhoc='$namhoc', nhanxetchung='$nhanxetchung', uudiem='$uudiem', cachkhacphuc='$cachkhacphuc', duoclenlop= '$duoclenlop' WHERE ID = '$ID'";
            $stmt = $conn->prepare($sql);
            $query = $stmt->execute();
            if($query){
                header('location: admin.php');
                exit();
            }
            else{
                echo "sua that bai";
            }
        }
    }
?>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Thêm van don</title>
</head>

<body>
    <header>
        
        <div class="tieude">
            <h1>Sửa </h1>
        </div>
    </header>
    <content>
        <div class="container">
            <form method="post">
                <fieldset class="form-group">
                    <label>Ma </label>
                    <input type="text" name="hocsinh_id" value="<?php echo $item['hocsinh_id']?>"
                        placeholder="nhap hoc sinh" class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>Nam hoc</label>
                    <input type="text" name="namhoc" value="<?php echo $item['namhoc']?>" placeholder=" nam hoc" class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>nhan xet chung</label>
                    <input type="text" name="nhanxetchung" value="<?php echo $item['nhanxetchung']?>"
                        placeholder="nhap" class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>uu diem</label>
                    <input type="text" name="uudiem" value="<?php echo $item['uudiem']?>"
                        placeholder="nhap " class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>cach khac phuc</label>
                    <input type="text" name="cachkhacphuc" value="<?php echo $item['cachkhacphuc']?>"
                        placeholder="nhap " class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>Duoc len lop</label>
                    <input type="text" name="duoclenlop" value="<?php echo $item['duoclenlop']?>"
                        placeholder="len lop" class="form-control">
                </fieldset>
                <br>
                <fieldset class="form-group">
                    <input type="submit" name="submit" value="Save" class="form-control">
                    <br>
                    <input type="button" class="form-control" value="Back" onclick="window.location= 'admin.php'">
                </fieldset>
            </form>
        </div>
    </content>
    <footer>
        <label>Phạm Thị Ngân_90856</label>
    </footer>
</body>

</html>