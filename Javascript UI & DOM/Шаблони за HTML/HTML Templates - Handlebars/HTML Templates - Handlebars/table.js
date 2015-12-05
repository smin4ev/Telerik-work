var categories;
var categoriesTamplateHTML;
var categoriesTemplate;


categories = [{
    number:'1',
    title:'Course Instroduction',
    firstData:'Wed 18:00,  28-May-2014',
    secondData:'Fri 14:00,  29-May-2014'
}, {
    number:'2',
    title:'Documant Object Model ',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number:'3',
    title:'HTML 5 Canvas',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '4',
    title: 'Kinetic JS Overview',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '5',
    title: 'SVG and RaphaelJS',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '6',
    title: 'DOM Operations',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '7',
    title: 'Event model',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '8',
    title: 'jQuery overviwe',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '9',
    title: 'HTML templates',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '10',
    title: 'Exam preparation',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '11',
    title: 'Exam',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}, {
    number: '12',
    title: 'Teamwork defence',
    firstData: 'Wed 18:00,  28-May-2014',
    secondData: 'Fri 14:00,  29-May-2014'
}]

categoriesTamplateHTML = document.getElementById('table-template').innerHTML;
categoriesTemplate = Handlebars.compile(categoriesTamplateHTML);
document.getElementById('root').innerHTML = categoriesTemplate({ categories: categories });