function bicycle() {
    var canvas = document.getElementById("the-canvas");
    var ctx = canvas.getContext("2d");

    ctx.beginPath();
    ctx.arc(150, 500, 50, 0, 2 * Math.PI);
    ctx.fillStyle = '#90cad7';
    ctx.fill();
    ctx.lineWidth = 2;
    ctx.strokeStyle = '#418899';
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(350, 500, 50, 0, 2 * Math.PI);
    ctx.fillStyle = '#90cad7';
    ctx.fill();
    ctx.lineWidth = 2;
    ctx.strokeStyle = '#418899';
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(150, 500);
    ctx.lineTo(210, 430);
    ctx.lineTo(310, 430);
    ctx.lineTo(240, 490);
    ctx.closePath();
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(350, 500);
    ctx.lineTo(290, 390);
    ctx.lineTo(310, 360);
    ctx.stroke()

    ctx.beginPath();
    ctx.moveTo(290, 390);
    ctx.lineTo(255, 400);
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(240, 490, 10, 0, 2 * Math.PI);
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(247, 497);
    ctx.lineTo(258, 509);
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(233, 483);
    ctx.lineTo(221, 471);
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(240, 490);
    ctx.lineTo(195, 400);
    ctx.lineTo(220, 400)
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(195, 400);
    ctx.lineTo(170, 400);
    ctx.stroke();


}
bicycle();


function faceWithHat() {
    var canvas = document.getElementById("the-canvas");
    var ctx = canvas.getContext("2d");

    //face
    ctx.beginPath();
    ctx.arc(180, 200, 50, 0, 2 * Math.PI);
    ctx.fillStyle = '#90cad7';
    ctx.fill();
    ctx.lineWidth = 2;
    ctx.strokeStyle = '#418899';
    ctx.stroke();

    //mount
    ctx.save();
    ctx.rotate(8 * Math.PI / 180);
    ctx.scale(3, 1);
    ctx.beginPath();
    ctx.arc(65, 205, 6, 0, 2 * Math.PI);
    ctx.strokeStyle = '#194b56';
    ctx.lineWidth = 1;
    ctx.stroke();
    ctx.restore();

    //eyes
    ctx.save();
    ctx.scale(1.5, 1);
    ctx.beginPath();
    ctx.arc(100, 185, 5, 0, 2 * Math.PI);
    ctx.strokeStyle = '#194b56';
    ctx.lineWidth = 1.5;
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(130, 185, 5, 0, 2 * Math.PI);
    ctx.strokeStyle = '#194b56';
    ctx.lineWidth = 1.5;
    ctx.stroke();
    ctx.restore();

    ctx.save();
    ctx.scale(1, 2);
    ctx.beginPath();
    ctx.arc(148, 92, 2.5, 0, 2 * Math.PI);
    ctx.fillStyle = '#194b56';
    ctx.fill();

    ctx.beginPath();
    ctx.arc(193, 92, 2.5, 0, 2 * Math.PI);
    ctx.fillStyle = '#194b56';
    ctx.fill();
    ctx.restore();

    //hat - lower part
    ctx.save();
    ctx.scale(3, 1);
    ctx.beginPath();
    ctx.arc(60, 150, 18, 0, 2 * Math.PI);
    ctx.lineWidth = 1;
    ctx.fillStyle = '#396693';
    ctx.fill();
    ctx.strokeStyle = '000000';
    ctx.stroke();
    ctx.restore();

    //hat - upper part
    ctx.save();
    ctx.beginPath();
    ctx.strokeStyle = '000000';
    ctx.moveTo(160, 70);
    ctx.lineTo(160, 135);
    ctx.quadraticCurveTo(180, 150, 215, 135);
    ctx.lineTo(215, 70);
    ctx.fillStyle = '#396693';
    ctx.fill();
    ctx.quadraticCurveTo(180, 85, 160, 70);
    ctx.quadraticCurveTo(190, 55, 215, 70);
    ctx.fillStyle = '#396693';
    ctx.fill();
    ctx.stroke();
    ctx.restore();

    //nose
    ctx.beginPath();
    ctx.moveTo(170, 205);
    ctx.lineTo(160, 205);
    ctx.lineTo(170, 185);
    ctx.strokeStyle = '#194b56';
    ctx.stroke();

}
faceWithHat();


function redHouse() {
    var canvas = document.getElementById("the-canvas");
    var ctx = canvas.getContext("2d");

    //house
    ctx.beginPath();
    ctx.moveTo(500, 200);
    ctx.lineTo(500, 450);
    ctx.lineTo(800, 450);
    ctx.lineTo(800, 200);
    ctx.lineTo(500, 200);
    ctx.fillStyle = '#975b5b';
    ctx.fill();
    ctx.lineTo(650, 50);
    ctx.lineTo(800, 200);
    ctx.fill();
    ctx.strokeStyle = '000000';
    ctx.stroke();

    //windows
    houseWindow(520, 220, 100, 70);
    houseWindow(680, 220, 100, 70);
    houseWindow(680, 360, 100, 70);

    //door
    ctx.beginPath();
    ctx.moveTo(530, 450);
    ctx.lineTo(530, 360);
    ctx.quadraticCurveTo(560, 330, 590, 360);
    ctx.lineTo(590, 450);
    ctx.moveTo(560, 450);
    ctx.lineTo(560, 345);
    ctx.strokeStyle = '000000';
    ctx.stroke();

    //lock
    ctx.beginPath();
    ctx.arc(550, 415, 3, 0, 2 * Math.PI);
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(570, 415, 3, 0, 2 * Math.PI);
    ctx.stroke();

    //chimney
    ctx.beginPath();
    ctx.moveTo(715, 150);
    ctx.lineTo(715, 90);
    ctx.quadraticCurveTo(725, 80, 735, 90);
    ctx.lineTo(735, 150);
    ctx.moveTo(715, 90);
    ctx.fillStyle = '#975b5b';
    ctx.fill();
    ctx.quadraticCurveTo(725, 100, 735, 90);
    ctx.stroke();


}


redHouse();

function houseWindow(x, y, width, height) {
    var canvas = document.getElementById("the-canvas");
    var ctx = canvas.getContext("2d");

    ctx.fillStyle = '000000';
    ctx.fillRect(x, y, width, height);
    ctx.beginPath();
    ctx.moveTo(x, y + height / 2);
    ctx.lineTo(x + width, y + height / 2);
    ctx.lineWidth = 2;
    ctx.strokeStyle = '#975b5b';
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(x + width / 2, y);
    ctx.lineTo(x + width / 2, y + height);
    ctx.lineWidth = 2;
    ctx.strokeStyle = '#975b5b';
    ctx.stroke();
}