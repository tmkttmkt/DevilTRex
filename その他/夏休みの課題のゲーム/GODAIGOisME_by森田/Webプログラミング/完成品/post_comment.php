<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST["username"];
    $message = $_POST["message"];
    $message3

    // ユーザー名とメッセージを整形
foreach ($message as $messages) {
    list($message3) = explode(':', $userData);
    if($message3 == 'サムライソード'){
    	$formattedMessage = "$username: $message\n";

    // テキストファイルに追記
    	file_put_contents("messages.txt", $formattedMessage, FILE_APPEND);
	header("Location: keijiban.php");
	exit();
}else{
 echo '書き込みに失敗しました';
}
}
}

// メインの掲示板画面にリダイレクト
?>