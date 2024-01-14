<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>掲示板</title>
</head>
<style>
body{
background-image: url('login.png');
background-size: cover;
}
.container {
  position: relative;
  width: 100vw;
  height: 100vh;
  overflow: hidden;
}
.vertical-hr {
      position: fixed;
      top: 0px;
      left: 250px;
      border-left: 2px solid black; 
      height: 100vh; 
      margin: 0; /
    }
.vertical-hr2 {
      position: fixed;
      top: 0px;
      left: 950px;
      border-left: 2px solid black; 
      height: 100vh; 
      margin: 0; /
    }
#scare{
top:250px;
left:120px;
width: 25%;
height: auto;
background-color: #0000FF;
}
.transparent-image {
  width: 100%;
  height: 100%;
  opacity: 0.5;
}
input[name ="submit_button_2"] {
           position: fixed;
	    top: 0px;
            left: 0px;
            width: 150px; /* 幅を変更する場合は適切なサイズを指定 */
            height: 60px; /* 高さを変更する場合は適切なサイズを指定 */
            /* その他のスタイルを追加できます */
	    font-size: 22px;
	    color: white;
	    background-color: #000000;
        }
button[id ="scroll"] {
           position: fixed;
	    top: 0px;
            left: 170px;
            width: 150px; /* 幅を変更する場合は適切なサイズを指定 */
            height: 60px; /* 高さを変更する場合は適切なサイズを指定 */
            /* その他のスタイルを追加できます */
	    font-size: 22px;
	    color: white;
	    background-color: #000000;
        }
button[id ="scroll_down"] {
           position: fixed;
	    top: 0px;
            left: 340px;
            width: 150px; /* 幅を変更する場合は適切なサイズを指定 */
            height: 60px; /* 高さを変更する場合は適切なサイズを指定 */
            /* その他のスタイルを追加できます */
	    font-size: 22px;
	    color: white;
	    background-color: #000000;
        }
.black-square {
      position: fixed;
      top: 0px;
      left: 0px;
      width: 100vw; 
      height: 60px; 
      
      background-color: black;
    }
.white-square {
      position: fixed;
      top: 0px;
      left: 250px;
      width: 700px;
      height: 100vh; 
      
      background-color: white; 
    }
 h3{
 position: absolute;
left: 22%;
color: #0000FF;
font-size: 52px;
 }
 h2{
 position: absolute;
size: 27px;
left: 25%;
color: #000000;
opacity: 1;
 }
 h4{
 position: absolute;
font-size: 30px;
text-align: center;
top: 120px;
left: 360px;
color: #FF0000;
opacity: 1;
 }
 h5{
 position: absolute;
font-size: 30px;
text-align: center;
top: 90px;
left: 320px;
color: #FF0000;
opacity: 1;
 }
.centers{
 position: absolute;
 left: 30%;
opacity: 1;
}
</style>

<body>
<div class="white-square"></div>
<div class="vertical-hr"></div>
<div class="vertical-hr2"></div>
<h3><u>サムライソードの一行掲示板</u></h3>
<imput type="submit" value="ログイン">
<br><br>
<?php
$hyouji = "";
$counts = 0;
$lastElement = "";
$lastElement2 = 0;
date_default_timezone_set('Asia/Tokyo');
$currentTime = date("Y年m月d日 H時i分s秒");
$list = array();
// ファイルのパス
$filePath = 'komento.txt';
$filePath2 = 'bango.txt';
$numericLastElement = "";


// コメントの読み込み
function yomikomi() {
    global $filePath;
    $comments = file($filePath,FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
    return $comments;
}


// コメントの書き込み
function kakikomi($comment) {
    global $filePath;
    file_put_contents($filePath,$comment . PHP_EOL, FILE_APPEND);
}

// 投稿ボタンが押されたとき
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $name = $_POST['name'];
    $message = $_POST['message'];

    // 「サムライソード」が含まれているか確認
    if (stripos($message, 'サムライソード') !== false && strpos($message, "\n") === false) {
        $comment = "$name\n$currentTime\n$message\n\n";
        kakikomi($comment);
	echo "<script>" . "scrollTops()" . "</script>";
	echo "<h4>". "<u>"."書き込みに成功しました！！<br><br>"."</u>"."</h4>"."<br>","<br>"."<br>","<br>"."<br>","<br>"."<br>";
    } else {
        echo "<script>" . "scrollTops()" . "</script>";
        echo "<h5>"."コメントには「サムライソード」という<br>文字が含まれている必要があります。<br>もしくは改行もしちゃだめです。<br>※これが" . "<u>"."ルール". "</u>" ."です。<br><br>"."</h5>" ."<br>","<br>"."<br>","<br>"."<br>","<br>"."<br>"."<br>","<br>","<br>";
    }
}else{
echo "<h4>". "<u>"."ルールを守って<br>楽しくおしゃべりしましょう！<br><br>"."</u>"."</h4>"."<br>","<br>"."<br>","<br>"."<br>","<br>"."<br>","<br>";
}

// コメントの表示
$comments = yomikomi();
$counts = count($comments) / 3;
if (!empty($comments)) {
for ($i=0;$i < $counts; $i++) {
    $index = $i + 1;
    $name = $comments[$i * 3];
    $time = $comments[$i * 3 + 1];
    $comment = $comments[$i * 3 + 2];
    echo  "<h2>"  . strval($index) . '. '."<u>" . $name ."</u>". 'さん'." " . $time . '<br>' . '　' . nl2br(htmlspecialchars($comment)) . '<br>','<br>','</h2>' . '<br>' . '<br>' . '<br>' . '<br>';
}
}else{
 echo  "<h2>" . 'まだコメントは無いようです。' . '</h2>' .'<br>'.'<br>';
}
?>
<div class="centers">
<br>
<form method="post" action="">
    <label for="name">名前：</label>
    <input type="text" name="name" required><br><br>
    <label for="message">コメント</label>
    <br>
    <textarea name="message" rows="4" cols="50" required></textarea><br>
    <input type="submit" name="submit_button_1" value="投稿">
</form>
</div>
<div class="black-square"></div>
<button id="scroll" onclick="scrollTops()">ページの最上部へ</button>
<button id="scroll_down" onclick="scrollDowns()">ページの最下層へ</button>
    <a href = "変わる四角.html"><input type="submit" name="submit_button_2" value="ホームへ"></a>
<script>
 function scrollTops() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0;
  }
function scrollDowns() {
    window.scrollTo(0, document.body.scrollHeight || document.documentElement.scrollHeight);
  }
</script>
</body>
</html>