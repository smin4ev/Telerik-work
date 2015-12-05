var paper = Raphael(10, 10, 700, 500);
var rect = paper.rect(10, 10, 550, 140);
var redRect = paper.rect(250, 30, 300, 100, 35);
var textYou = paper.text(130, 80, 'YOU');
var textTube = paper.text(400, 80, 'TUBE');

redRect.attr({
    fill: 'red',
    stroke:'none'
});

textYou.attr({
    'font-weight': 'bold',
    'font-size': '100px',
});

textTube.attr({
    'font-weight': 'bold',
    'font-family': 'Arial',
    'font-size': '100px',
    fill:'white'
    
});