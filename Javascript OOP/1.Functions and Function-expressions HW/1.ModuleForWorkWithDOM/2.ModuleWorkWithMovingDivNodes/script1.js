var movingShapes = (function () {
    function add(shape) {
        var createNewDiv = document.createElement('div');
        createNewDiv.innerHTML = 'DIV';
        createNewDiv.style.fontSize = getRandomValue(10, 20) + 'px';
        createNewDiv.style.width = getRandomValue(20, 100) + 'px';
        createNewDiv.style.height = getRandomValue(20, 100) + 'px';
        createNewDiv.style.backgroundColor = makeRandomColor();
        createNewDiv.style.borderColor = makeRandomColor();
        createNewDiv.style.textAlign = 'center';
        createNewDiv.style.position = 'absolute';


        var wrapper = document.getElementById('wrapper');
        wrapper.appendChild(createNewDiv);

        if (shape === 'ellipce') {
            var centerX = 500;
            var centerY = 200;
            //var radiusA = 150;
            //var radiusB = 50;
            var radius = 150;
            var angle = 0;
           
            var functionTimer = setInterval(function moveDivs() {
                angle++;
                if (angle === 360) {
                    angle = 0;
                }

                var left = centerX + Math.cos((2 * 3.14 / 180) * (angle)) * radius;
                var right = centerY + Math.sin((2 * 3.14 / 180) * (angle)) * radius;


                createNewDiv.style.left = left + 'px';
                createNewDiv.style.top = right + 'px';

            }, 20);
        }

        else if (shape === 'rect') {
            var centerX = 400;
            var centerY = 200;
            

            var directionOfMovementOfRect = 0;//There are 4 direction - left, bottom, rigth, top - we change direction of movement with changing of this value

            var functionTimer = setInterval(function moveDivs() {
                if (directionOfMovementOfRect > 3) {
                    directionOfMovementOfRect = 0;
                }

                if (directionOfMovementOfRect == 0) {
                    centerX = centerX + 5;
                    if (centerX > 500) {
                        directionOfMovementOfRect = 1;
                    }
                }
                else if (directionOfMovementOfRect == 1) {
                    centerY = centerY + 5;
                    if (centerY > 400) {
                        directionOfMovementOfRect = 2;
                    }
                }
                else if (directionOfMovementOfRect == 2) {
                    centerX = centerX - 5;
                    if (centerX < 400) {
                        directionOfMovementOfRect = 3;
                    }
                }
                else if (directionOfMovementOfRect == 3) {
                    centerY = centerY - 5;
                    if (centerY < 200) {
                        directionOfMovementOfRect++;
                    }
                }

                createNewDiv.style.left = centerX + 'px';
                createNewDiv.style.top = centerY + 'px';

            }, 20);
        }

    }

    function makeRandomColor() {
        var red = getRandomValue(0, 255);
        var green = getRandomValue(0, 255);
        var blue = getRandomValue(0, 255);


        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }

    function getRandomValue(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    return {
        add:add
    }
}());