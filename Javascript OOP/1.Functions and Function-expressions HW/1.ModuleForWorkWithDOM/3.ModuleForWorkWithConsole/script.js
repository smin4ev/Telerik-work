var specialConsole = (function () {
    function writeLine(message, placeHolders) {
        if (placeHolders) {
            message = replaceHolders(message, arguments);
        }
        console.log(message);
    }

    function writeError(errorMessage, placeHolders) {
        if (placeHolders) {
            errorMessage = replaceHolders(errorMessage, arguments);
        }
        console.error(errorMessage);
    }

    function writeWarning(waringMessage, placeHolders) {
        if (placeHolders) {
            waringMessage = replaceHolders(waringMessage, arguments);
        }
        console.warn(waringMessage);
    }

    function replaceHolders(currentMessage, currentArguments) {
        for (var i = 0; i < currentArguments.length; i++) {
            while (currentMessage.indexOf('{' + i + '}') != -1) {
                currentMessage = currentMessage.replace('{' + i + '}', currentArguments[i + 1]);
            }
        }
        return currentMessage;
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
})();
