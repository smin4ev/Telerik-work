var domModule = (function () {
    var buffer = [];

    var appendChild = function (element, parentSelector) {
        var parent = document.querySelector(parentSelector)
        parent.appendChild(element);
    }

    var removeChild = function (parentElement, childElement) {
        var parent = document.querySelector(parentElement);
        var child = document.querySelector(childElement);
        parent.removeChild(child);
    }

    var addHandler = function (selector, eventType, eventHandler ) {
        var selectedElement = document.querySelector(selector);
        selectedElement.addEventListener(eventType, eventHandler);
    }

    var appendToBuffer = function (selector, element) {
        if (buffer[selector]) {
            buffer[selector].push(element);
        }
        if (buffer[selector].length == 100) {
            var frag = document.createDocumentFragment();
            for (var i = 0; i < buffer[selector].length; i++) {
                frag.appendChild(buffer[selector][i])
            }
            var parent = document.querySelector(selector);
            parent.appendChild(frag);

            buffer[parent] = [];
        }
        else {
            buffer[parent] = [];
            buffer[selector].push(element);
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    }
}())
