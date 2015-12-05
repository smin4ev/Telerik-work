var paper = Raphael(10, 10, 700, 500);
var path = paper.path('M 30 50 L 50 30 L 110 90 L 80 120 L 50 90 L 112 30 L 132 50');
var textTelerik = paper.text(350, 80, 'TELERIK');
var textUnder = paper.text(407, 140, 'Develop experiences');
var circle = paper.circle(570, 51, 6);
var R = paper.text(569, 50,'R');
var rect = paper.rect(10, 10, 660, 180);

path.attr({
    stroke: '#5ce600',
    'stroke-width': 8
});

textTelerik.attr({
    'font-size': '100px',
    'font-weight':'bold'
});

textUnder.attr({
    'font-size': '54px'
});
rect.attr({
    stroke: '#5ce600'
});
