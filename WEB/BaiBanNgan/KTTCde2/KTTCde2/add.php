<!DOCTYPE html>
<html lang="en">
<?php 
    session_start();
    if(!isset($_SESSION['tendaydu'])){
        header('location: login.php');
    }
    include('connect.php');
    if(!empty($_POST['submit'])){
        if(isset($_POST['hocsinh_id']) && isset($_POST['namhoc']) && isset($_POST['nhanxetchung']) && isset($_POST['uudiem']) && isset($_POST['cachkhacphuc']) && isset($_POST['duoclenlop'])){
            $hocsinh_id = $_POST['hocsinh_id'];
            $namhoc = $_POST['namhoc'];
            $nhanxechung = $_POST['nhanxetchung'];
            $uudiem = $_POST['uudiem'];
            $cachkhacphuc = $_POST['cachkhacphuc'];
            $duoclenlop = $_POST['duoclenlop'];

            $sql = "INSERT INTO tongketnam(hocsinh_id, namhoc, nhanxetchung, uudiem, cachkhacphuc, duoclenlop) VALUES('$hocsinh_id', '$namhoc', '$nhanxetchung', '$uudiem', '$cachkhacphuc', '$duoclenlop' )";
            $stmt = $conn->prepare($sql);
            $query = $stmt->execute();
            if($query){
                header('location: admin.php');
                exit();
            }
            else{
                echo "them that bai";
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
    <title>Thêm vận đơn</title>
</head>

<body>
    <header>
        
        <div class="tieude">
            <h1>Thêm </h1>
        </div>
    </header>
    <content>
        <div class="container">
            <form method="post">
                <fieldset class="form-group">
                    <label>hocsinh</label>
                    <input type="text" name="hocsinh_id" placeholder="nhap" class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>nam hoc</label>
                    <input type="text" name="namhoc" placeholder="nhap" class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>Nhan xet chung</label>
                    <input type="text" name="nhanxetchung" placeholder="nhap " class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>Uu diem</label>
                    <input type="text" name="uudiem" placeholder="nhap " class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>cach khac phuc</label>
                    <input type="text" name="cachkhacphuc" placeholder="nhap "
                        class="form-control">
                </fieldset>
                <fieldset class="form-group">
                    <label>duoc len lop</label>
                    <input type="text" name="duoclenlop" placeholder="len lop" class="form-control">
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
        <label>Phạm Thị Ngân_ 90856</label>
        <br>
        <label>Hi <?php echo $_SESSION['tendaydu']?></label>
    </footer>
</body>

</html>