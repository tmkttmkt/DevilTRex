<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST["username"];
    $message = $_POST["message"];
    $message3

    // ���[�U�[���ƃ��b�Z�[�W�𐮌`
foreach ($message as $messages) {
    list($message3) = explode(':', $userData);
    if($message3 == '�T�����C�\�[�h'){
    	$formattedMessage = "$username: $message\n";

    // �e�L�X�g�t�@�C���ɒǋL
    	file_put_contents("messages.txt", $formattedMessage, FILE_APPEND);
	header("Location: keijiban.php");
	exit();
}else{
 echo '�������݂Ɏ��s���܂���';
}
}
}

// ���C���̌f����ʂɃ��_�C���N�g
?>