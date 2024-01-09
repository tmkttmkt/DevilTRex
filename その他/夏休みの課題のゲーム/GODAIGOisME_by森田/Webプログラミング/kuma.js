var canvas
var img,bkimg
var x = 200;
var y = 200;
var i = -1;
var j = 1;
var speed = 10;
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
	x += speed * i;
	y += speed * j
	if(x < 0){
	i = 1;
	flg = 1;
	}
	if(x + speed -10 > 400){
	flg = 0;
	speed += 5;
	i = -1;
	}
	
	if(y - (speed - 10) < 0){
	j = 1;
	}
	if(y + 100 + speed -10 > 400){
	j = -1;
	speed += 5;
	}
	context.drawImage(img,x,y);
}