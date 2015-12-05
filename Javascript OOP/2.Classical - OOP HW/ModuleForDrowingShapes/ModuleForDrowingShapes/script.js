//var drawingShapes = (function () {
//    function Canvas(selector) {
//        this.selector = selector
//    }

//    Canvas.prototype = {
//        drawRect: function drawRect(x, y, width, height) {
//            var can = document.querySelector(this.selector)
//            var ctx = can.getContext('2d');
//            ctx.beginPath();
//            ctx.rect(x, y, width, height);
//            ctx.closePath();
//            ctx.stroke();
//        },
//        drawCircle: function drawCircle(x, y, radius) {
//            var cnv = document.querySelector(this.selector);
//            var ctx = cnv.getContext('2d');
//            ctx.beginPath();
//            ctx.arc(x, y, radius, 0, 2 * Math.PI);
//            ctx.closePath();
//            ctx.stroke();
//        },
//        drawLine: function drawLine(x1, y1, x2, y2) {
//            var cnv = document.querySelector(this.selector);
//            var ctx = cnv.getContext('2d');
//            ctx.beginPath();
//            ctx.moveTo(x1, y1);
//            ctx.lineTo(x2, y2);
//            ctx.stroke();
//        } 
//    }
//    return Canvas;
//}());

function DrawFigure() {

}
    DrawFigure.prototype = {
        drawLine: function (startX, startY, endX, endY) {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            var result = canvas();
            result.beginPath();
            result.moveTo(startX, startY);
            result.lineTo(endX, endY);
            result.stroke();  
        },
        drawRect: function (x, y, width, height) {
            this.x = x;
            this.y = y;
            this.widht = width;
            this.height = height;
            var result = canvas();
            result.beginPath();
            result.rect(x, y, width, height);
            result.closePath();
            result.stroke();
        },
        drawCircle: function (centerX, centerY, radius, fillStyle) {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.fillStyle = fillStyle;
            var result = canvas();
            result.beginPath();
            result.arc(centerX, centerY, radius, 0, 2 * Math.PI);
            result.closePath();
            result.stroke();
            result.fillStyle = fillStyle;
            result.fill();
        } 
    }
function canvas() {
    var canv = document.getElementById('the-canvas');
    var ctx = canv.getContext('2d');
    return ctx;
}

var line1 = new DrawFigure();
line1.drawLine(30, 100, 200, 200);

var rect1 = new DrawFigure();
rect1.drawRect(50, 50, 120, 120);

var circle1 = new DrawFigure();
circle1.drawCircle(260, 100, 50, "red");