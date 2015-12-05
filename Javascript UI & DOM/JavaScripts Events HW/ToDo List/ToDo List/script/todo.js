var todo = function () {
    
    //creating div element  - otger elements will be in it
    var div = document.createElement('div');

    //create input field

    var inputField = document.createElement('input');
    inputField.type = 'text';
    inputField.id = 'item'
    div.appendChild(inputField);

    //create button for adding elements

    var btnAddElement = document.createElement('input');
    btnAddElement.type = 'button';
    btnAddElement.addEventListener('click', addElement);
    btnAddElement.value = 'Add element';
    div.appendChild(btnAddElement);

    //create button for removind elements

    var btnRemoveElement = document.createElement('input');
    btnRemoveElement.type = 'button';
    btnRemoveElement.addEventListener('click', removeElement)
    btnRemoveElement.value = 'Remove element';
    div.appendChild(btnRemoveElement);

    //create button for hiding elements

    var btnHideElement = document.createElement('input');
    btnHideElement.type = 'button';
    btnHideElement.addEventListener('click', hideElement);
    btnHideElement.value = 'Hide element';
    div.appendChild(btnHideElement);

    //create button for showing elements

    var btnShowElement = document.createElement('input');
    btnShowElement.type = 'button';
    btnShowElement.addEventListener('click', showElement);
    btnShowElement.value = 'Show element';
    div.appendChild(btnShowElement);

    //adding div to body

    document.body.appendChild(div);

    //creating unorder list(ul) for elements

    var list = document.createElement('ul');
    list.id = 'list';

    //adding ul to body

    document.body.appendChild(list);

    //function for adding elements in the list
    function addElement() {
        var valueInInputField = document.getElementById('item').value;
        if (valueInInputField !=='') {
            var listItem = document.createElement('li');
            listItem.style.listStyleType = 'none';
            var checkbox = document.createElement('input');
            checkbox.type = 'checkbox';
            listItem.appendChild(checkbox);
            listItem.appendChild(document.createTextNode(valueInInputField));
            var unorderedList = document.getElementById('list');
            unorderedList.appendChild(listItem);
        }
    }

    //function for removing elements from the list
    function removeElement() {
        var unorderList = document.getElementById('list');
        var checkedItems = document.querySelectorAll('input');
        for (var i = 0; len=checkedItems.length, i < len; i++) {
            if (checkedItems[i].checked) {
                unorderList.removeChild(checkedItems[i].parentElement);
            }
        }
    }

    //function for hiding elements from the list
    function hideElement() {
        var unorderList = document.getElementById('list');
        var checkedItems = document.querySelectorAll('input');
        for (var i = 0; len=checkedItems.length, i < len; i++) {
            if (checkedItems[i].checked) {
                checkedItems[i].parentElement.style.display = 'none';
                checkedItems[i].checked = false;
            }
        }
    }

    //function for showing hidden elements
    function showElement() {
        var unorderList = document.getElementById('list');
        var listItems = document.querySelectorAll('li');
        for (var i = 0; len=listItems.length, i < len; i++) {
            if (listItems[i].style.display === 'none') {
                listItems[i].style.display = 'block';
            }
        }
    }

}()
