///<reference path="libs/require.js" />
///<reference path="libs/jquery.js" />
///<reference path="controls.js" />

require(['controls', 'libs/jquery'], function (controls) {
    var people = [{ id: 1, name: "Gosho", age: 25, avatarUrl: "images/gosho.jpg" },
        { id: 2, name: "Pesho", age: 24, avatarUrl: "images/pesho.jpg" },
        { id: 3, name: "Ivan", age: 30, avatarUrl: "images/ivan.jpg" },
        { id: 4, name: "Nakov", age: 33, avatarUrl: "images/nakov.jpg" }];
    var comboBox = controls.ComboBox(people);
    var template = $("#person-template").html();
    var comboBoxHtml = comboBox.render(template);
    var container = document.getElementById('container');
    container.innerHTML = comboBoxHtml;
});