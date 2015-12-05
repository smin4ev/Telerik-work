$('#color').on('change', function () {
    var selectColor = $('#color').val();
    $('body').css('background', selectColor);
});