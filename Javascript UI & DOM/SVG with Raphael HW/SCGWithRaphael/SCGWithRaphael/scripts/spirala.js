var paper = Raphael(100,100,700, 600);
function spiral(centerX, centerY, a, b) {
    var centralPoint = "M" + centerX + ' ' + centerY,
        spiralPoints = [centralPoint];
    for (var i = 0; i < 1000; i++) {
        var angle = 0.1 * i,
   
            x = centerX + (a + b * angle) * Math.cos(angle),         
            y = centerY + (a + b * angle) * Math.sin(angle);

        spiralPoints.push('L ' + x + ' ' + y);

    }
    var spiralPointsStr = spiralPoints.join(' '),
    spiral = paper.path(spiralPointsStr);
}
spiral(350, 250, 0, 2);
