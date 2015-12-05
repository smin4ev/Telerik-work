var post;
var postTemplateHtml;
var postTemplate;

post = {
    tags: [{
        value: '1',
        text: 'one'
    }, {
        value: '2',
        text: 'two'
    }, {
        value: '3',
        text: 'three'
    }, {
        value: '4',
        text: 'four '
    }, {
        value: '5',
        text: 'five '
    }, {
        value: '6',
        text: 'six '
    }]
}

postTemplateHtml = document.getElementById('select-template').innerHTML;
postTemplate = Handlebars.compile(postTemplateHtml);
document.getElementById('root').innerHTML += postTemplate(post);