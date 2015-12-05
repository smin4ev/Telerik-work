/// <reference path="jquery.min.js" />
$('#btnAddBefore').on('click', function () {
    $('<div/>').addClass('before').html('Some text before existing div').insertBefore($('#existing'))
           
});

$('#btnAddAfter').on('click', function () {
    $('<div/>').addClass('after').html('Some text after existing div').insertAfter($('#existing'))

})