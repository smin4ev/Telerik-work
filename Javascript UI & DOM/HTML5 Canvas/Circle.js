var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

var width = canvas.width;
var height = canvas.height;
var xPosition = 0;
var yPosition = 0;
var radius = 10;
var xStep = 0;
var yStep = 0;


function createBall() {
    ctx.beginPath();
    ctx.arc(xPosition, yPosition, radius, 0, 2 * Math.PI);
    ctx.lineWidth = 1;
    ctx.fillStyle = 'orange';
    ctx.strokeStyle = 'green';
    ctx.fill();
    ctx.stroke();

}
function moveBall() {
    ctx.clearRect(0, 0, width, height);
    if (xPosition + radius >= width) {
        xStep = -2;
    }
    if (yPosition + radius >= height) {
        yStep = -2;
    }
    if (xPosition < radius) {
        xStep = 2;
    }
    if (yPosition < radius) {
        yStep = 2;
    }
    xPosition = xPosition + xStep;
    yPosition = yPosition + yStep;

    createBall(xPosition, yPosition);
    requestAnimationFrame(moveBall);
}

moveBall();