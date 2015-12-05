/// <reference path="jquery.min.js" />
(function () {
    $.fn.dropdown = function () {
        var $this = $(this);
        $this.hide();

        var $createDropdownDiv = $('<div></div>').addClass('dropdown-list-container');
        var $createList = $('<ul></ul>').addClass('dropdown-list-options');
        var $option = $this.find('option');

        for (var i = 0; i < $option.length; i++) {
            var $currentOption = $option[i];
            var currentOptionValue = $currentOption.value;
            var currentText = $currentOption.innerHTML;
            var $generateListItem = $('<li></li>')
                .addClass('dropdown-list-option')
                .html(currentText)
                .data('date-value', currentOptionValue);

            $createList.append($generateListItem);
        }
        $createDropdownDiv.append($createList);

        $this.after($createDropdownDiv);

        var generatedLiItems = $createDropdownDiv.find('.dropdown-list-option');

        $('.dropdown-list-option').on('click', function () {
            var data = $(this).data('data-value');
            var selector = 'option[value=\'' + data + '\']';

            if ($('#dropdown').find(selector).attr('selected') == 'selected') {
                $('#dropdown').find(selector).removeAttr('selected', '')
                $(this).css('background-color', '')
            }
            else {
                $('#dropdown').find(selector).attr('selected', 'selected')
                $(this).css('background-color', 'red')
            }
        });

        return $this;
    }
    
}())

$('#dropdown').dropdown();