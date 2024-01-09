<!DOCTYPE>
<html lanng="ja">
<head>
	<meta charset="UTF-8">
	<title>Hello!</title>
	<style>
	body{font-size:14pt; font-weight:plain;}
	h1{ color:white; font-size:24pt; background-color:green;}
	</style>
</head>
<?php
	echo "質問来てた！<br>";
	echo "<br>";
	echo $_POST['nendai']."";
	echo "の";
	echo $_POST['seibetu']."性の<br>";
	echo $_POST['namae']."さんから<br>";
	echo "<br>";
	echo $_POST['kanso']."<br>";
	echo "---------------------<br>";
	echo "<br>結論！";
	echo $_POST['keturon']."<br>";
?>
<body>
	<h1>料金計算</h1>
		お名前:<input type="text" name="namae"><br>
		年　代:<select name="nendai">
			<option value="10代">10代</option>
			<option value="20代">20代</option>
			<option value="30代">30代</option>
			<option value="40代">40代</option>
			<option value="50代">50代</option>
		</select><br>
		性　別:<input type="radio" name="seibetu" value=400 checked>0～6歳　幼児料金　300円
			<input type="radio" name="seibetu" value=500 checked>7～12歳　小学生料金　500円
			<input type="radio" name="seibetu" value=700 checked>13～15歳　中学生料金　700円
			<input type="radio" name="seibetu" value=900 checked>16～18歳　高校生料金　900円
			<input type="radio" name="seibetu" value=1200 checked>19～59歳　大人料金　1200円
			<input type="radio" name="seibetu" value=700 checked>60～　老人料金　700円
		質問:<br>
			<textarea name="kanso" rows="4" cols="40"></textarea><br><br>
		結論:<br>
			<textarea name="keturon" rows="4" cols="40"></textarea><br><br>
		<input type="submit" value="送信">
	</form>
</body>
</html>