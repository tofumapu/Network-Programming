<?php
    // Kết nối đến cơ sở dữ liệu
    $con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');
    
    if (mysqli_connect_errno()) {
        echo "1: Connection failed"; // Mã lỗi #1: Kết nối thất bại
        exit();
    }

    // Nhận dữ liệu từ client
    $username = $_POST['username'];
    $password = $_POST['password'];
    $confirm_password = $_POST['confirm_password'];

    // Kiểm tra dữ liệu đầu vào
    if (empty($username) || empty($password) || empty($confirm_password)) {
        echo "8: Missing input fields"; // Mã lỗi #8: Thiếu trường nhập
        exit();
    }

    if ($password !== $confirm_password) {
        echo "9: Passwords do not match"; // Mã lỗi #9: Mật khẩu không khớp
        exit();
    }

    // Kiểm tra username đã tồn tại chưa
    $namecheckquery = "SELECT username FROM players WHERE username='$username';";
    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // Mã lỗi #2: Lỗi kiểm tra tên

    if (mysqli_num_rows($namecheck) > 0) {
        echo "3: Username already exists"; // Mã lỗi #3: Username đã tồn tại
        exit();
    }

    // Tạo salt và hash mật khẩu
    $salt = "\$5\$rounds=5000\$" . "steamedhams" . $username . "\$"; // SHA-256 với salt động
    $hash = crypt($password, $salt);

    // Thực hiện thêm người dùng vào cơ sở dữ liệu
    $insertuserquery = "INSERT INTO players (username, hash, salt) VALUES ('$username', '$hash', '$salt');";
    if (!mysqli_query($con, $insertuserquery)) {
        echo "4: Insert player query failed: " . mysqli_error($con); // Mã lỗi #4: Thêm người dùng thất bại
        exit();
    }

    // Trả về kết quả thành công
    echo "0"; // Thành công
?>
