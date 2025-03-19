<?php
    $con = mysqli_connect
    (
        'localhost',
        'root',
        'root',
        'unityaccess'
    );
    if (mysqli_connect_errno())
    {
        echo "1: Connection failed"; // Error code #1: Connection failed
        exit();
    }

    if (!isset($_POST['username']) || !isset($_POST['password'])) {
        echo "Missing input fields";
        exit();
    }

    $username = trim($_POST['username']);
    $password = trim($_POST['password']);

    // Check if username exists
    $namecheckquery = "SELECT username, salt, hash, score FROM players WHERE TRIM(username)='" . $username . "';";
    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // Error code #2: Name check query failed

    if (mysqli_num_rows($namecheck) != 1)
    {
        echo "5: Either no user with name, or more than one"; // Error code #5: Number of names matching != 1
        exit();
    }

    // Get login info from query
    $existinginfo = mysqli_fetch_assoc($namecheck);
    $salt = trim($existinginfo["salt"]);
    $hash = trim($existinginfo["hash"]);

    $loginhash = crypt($password, $salt);
    if ($hash != $loginhash)
    {
        echo "6: Incorrect password or username"; // Error code #6: Incorrect password
        exit();
    }

    echo "0"
?>
