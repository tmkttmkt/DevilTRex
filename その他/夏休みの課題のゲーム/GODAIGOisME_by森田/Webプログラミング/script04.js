function draw(){
var canvas = document.querySelector('#canvas');
var context = canvas.getContext('2d');

context.beginPath();
context.fillStyle = "red";
context.rect(50,50,400,100);
context.fill();

context.beginPath();
context.fillStyle = "yellow";
context.rect(50,150,400,100);
context.fill();

context.beginPath();
context.fillStyle = "green";
context.rect(50,250,400,100);
context.fill();


}