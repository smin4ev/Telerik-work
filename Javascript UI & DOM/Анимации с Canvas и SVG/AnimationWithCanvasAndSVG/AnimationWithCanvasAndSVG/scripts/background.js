var paper = Raphael(0, 0, 600, 450);

var ground = paper.rect(0, 280, 600, 20);
ground.attr({
    stroke: 'none',
    fill: 'brown'
})

var environemnt = paper.rect(0, 0, 600, 280);
environemnt.attr({
    stroke: 'none',
    fill: '90-rgba(240,249,255,1):5-rgba(161,219,255,1):100'
})

var tree = paper.image('./images/treee.png', 600, 140, 130, 150);
var alwaysMove = Raphael.animation({ x: -150 }, 5000).repeat(Infinity);

tree.animate(alwaysMove);