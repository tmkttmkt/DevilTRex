<?php
session_start();
$error_message = '';
// ユーザー名とパスワードの確認
//$correct_username = 'katanaman';
//$correct_password = 'samurai_sword';

$usersFile = "users.txt";
$usersData = file($usersFile, FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
// ログインの試行があった場合
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input_username = $_POST['username'];
    $input_password = $_POST['password'];
    foreach ($usersData as $userData) {
        list($username, $password) = explode(':', $userData);
if ($input_username == $username && $input_password == $password) {
            echo "<p>Login successful! Welcome, $username!</p>";
            // マッチが見つかったらループを終了
             $_SESSION['loggedin'] = true;
       	     $_SESSION['username'] = $input_username;
             header('Location: 変わる四角.html');
             exit;
        }else{
 $error_message = 'ログインできませんでした。';
    }

    }
}

    // マッチが見つからなかった場合ログインが出来ませんでした {
       
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ログインページ</title>
</head>
<style>

.label-container {
  color: black;
  position: absolute;
  top: 50%;
  left: 50%;
  width: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
  //line-height: 1.5;
    }
#square{
position: fixed;
 width: 350px;
      height: 350px;
      top: 45%;
  left: 50%;
  transform: translate(-50%, -50%);
      background-color: #F2F2F2;
}
.centered-text2 {
	position: absolute;
	    top: 100px;
	    left: 430px;
	    line-height: 425px;
            color: black;
	    font-size: 18px;
        }
.centered-text3 {
	position: absolute;
	    top: 150px;
	    left: 430px;
	    line-height: 490px;
            color: black;
	    font-size: 18px;
        }
p.error-message {
	   text-align: center;
           position: absolute;
	   top: 230px;
	   left: 480px;
            color: red;
            font-size: 20px;
        }

.login {
	position: absolute;
	    left: 36%;
            color: black;
	    font-size: 40px;
        }
.centered-text {
	position: absolute;
	    top: 200px;
	    left: 520px;
            text-align: center;
            color: black;
	    font-size: 40px;
        }
        .hidden-label {
            position: absolute;
            top: 318px;
            left: 540px;
	    width: 100%;
            transform: translateY(-50%);
            color: #999; 
            pointer-events: none; 
            transition: 0.3s; 
	    opacity: 1;
        }
.hidden-label-2 {
            position: absolute;
            top: 400px;
            left: 540px;
	    width: 100%;
            transform: translateY(-50%);
            color: #999; 
            pointer-events: none; 
            transition: 0.3s;
	    opacity: 1;
        }

        .input-field {
	   position: absolute;
	   top: 380px;
	    left: 530px;
            padding: 8px;
        }
input[type="submit"] {
	   position: absolute;
	   top: 450px;
	    left: 445px;
            width: 300px; /* 幅を変更する場合は適切なサイズを指定 */
            height: 60px; /* 高さを変更する場合は適切なサイズを指定 */
            /* その他のスタイルを追加できます */
	    font-size: 22px;
	    color: white;
	    background-color: #3BAF75;
        }
        .input-field:focus + .hidden-label {
            opacity: 0; /* 入力フィールドにフォーカスが当たると非表示にする */
        }
	.input-field:focus + .hidden-label-2 {
            color: rgba(F2, F2, F2, 1);
        }
</style>
<body>
    <body bgcolor="#000000">
    <h2>ログイン</h2>
<div id="square"></div>
    <form method="post" action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>">


<input style = "top: 380px;left: 530px;width: 200px;" type="text" class="input-field" id="password" name="password">
<input style = "top: 300px;left: 530px;width: 200px;" type="text" class="input-field" id="username" name="username">
<div class="centered-text">ログイン</div>
    <?php if (isset($error_message)) : ?>
        <p class="error-message"><?php echo $error_message; ?></p>
    <?php endif; ?>
<div class="centered-text2">User name</div><br>
<div class="centered-text3">Password</div>
        <label style="font-size: 16px;"for="username2" class="hidden-label">じゃあ</label>
<label style="font-size: 16px;"for="password2" class="hidden-label-2">切り殺してやるよ</label>
<input type="submit" value="ログイン">//
    </form>

<script>
        // input要素がクリックされたときの処理
        document.getElementById('username').addEventListener('click', function() {
            // hidden-label-2のopacityを変更する
            var hiddenLabel1 = document.querySelector('.hidden-label');
            hiddenLabel1.style.opacity = '0'; // ここで適切な透明度を設定
        });
	document.getElementById('password').addEventListener('click', function() {
            // hidden-label-2のopacityを変更する
            var hiddenLabel2 = document.querySelector('.hidden-label-2');
            hiddenLabel2.style.opacity = '0'; // ここで適切な透明度を設定
        });
    </script>
</body>

</html>