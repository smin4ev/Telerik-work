var tags = ["cms", "javascript", "javascript", "javascript", "javascript", "javascript", "javascript", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"]
var div = document.getElementById('tags');
div.style.width = 200 + 'px';
var tagCloud = generateTagCloud(tags, 17, 42);


function generateTagCloud(tags, minFontSize, maxFontSize) {
    var counterArr = [];


    for (var i = 0; i < tags.length; i++) {
        var count = 0;


        for (var c = i + 1; c < tags.length; c++) {
            if (tags[i].toLowerCase() == tags[c].toLowerCase()) {
                count++;
                tags.splice(c, 1);
                c--;
            }
        }


        counterArr.push(count);
    }


    for (var i = 0; i < tags.length; i++) {
        console.log(counterArr[i]);
        var result = document.createElement('span');
        result.style.fontSize = counterArr[i] <= 0 ? minFontSize : (counterArr[i] >= maxFontSize ? maxFontSize : minFontSize + counterArr[i] * 2) + 'px';
        result.appendChild(document.createTextNode(tags[i] + ' '));
        div.appendChild(result);
    }


    return false;
}
