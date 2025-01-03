<?php
session_start();
if(isset($_SESSION['username']) AND $_SESSION['username']!=NULL){
    unset($_SESSION['username']);
    header('location: login.php');
}
?>