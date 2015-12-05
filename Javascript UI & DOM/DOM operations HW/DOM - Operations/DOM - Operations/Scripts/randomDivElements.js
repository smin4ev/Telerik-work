function createDivElements() {
    var main = document.getElementById('main');
    divCount = 15;
    for (var i = 0; i < divCount; i++) {
        var newDiv = document.createElement('div');
        newDiv.style.width = getRandomValue(20, 100) + 'px';
        newDiv.style.height = getRandomValue(20, 100) + 'px';
        newDiv.style.background = 'rgb(' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ')';
        newDiv.style.color = 'rgb(' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ')';
        newDiv.style.border = getRandomValue(1, 20) + 'px' + ' solid ' + 'rgb(' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ',' + getRandomValue(0, 254) + ')';
        newDiv.style.borderRadius = getRandomValue(1, 10) + 'px';
        newDiv.style.position = getRandomPosition(); 
        var strong = document.createElement('strong');
        strong.innerHTML = 'Div #' + (i + 1);
        newDiv.appendChild(strong);
        main.appendChild(newDiv);

        //Decisions without DocumentFragment
    }
}
createDivElements();
function getRandomValue(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomPosition() {
    var positions = ['static', 'absolute', 'fixed', 'relative', 'initial', 'inherit'];
    var randomElement = positions[Math.floor(Math.random() * positions.length)];
    return randomElement;

}