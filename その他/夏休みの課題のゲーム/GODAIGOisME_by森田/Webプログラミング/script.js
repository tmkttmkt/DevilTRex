var canvas
var img,bkimg
var x = 200;
var y = 200;
var i = -1;
var j = 1;
function init(){
	canvas = document.querySelector('#canvas');
	canvas.focus();
	img = new Image();
	img.src = "character.png";
	bkimg = new Image();
	bkimg.src = "background.png";
	bkimg.onload = function(){
		drawBackground();
		timer = setInterval(draw,50);
	}
}
function draw(event){
	drawBackground();
	drawImage(event);
}
function drawBackground(event){
	var context = canvas.getContext('2d');
	context.clearRect(0,0,500,400);
	context.drawImage(bkimg,0,0,500,400);
}
function drawImage(evant){
	var context = canvas.getContext('2d');
	x += 10 * i;
	y += 10 * j
	if(x < 0){
	i = 1;
	flg = 1;
	}
	if(x> 400){
	flg = 0;
	i = -1;
	}
	
	if(y < 0){
	j = 1;
	}
	if(y + 100 > 400){
	j = -1;
	}
	context.drawImage(img,x,y);
}