</div>
<footer>
    <p>Bùi Thị Hồng Nhung - 84322</p>
    <?php
    //session_start();
    if (isset($_SESSION['username'])) {
        ?>
        <p>Đăng nhập với tên <?php echo $_SESSION['username'] ?></p>
    <?php } ?>
</footer>
</div>

</body>

</html>