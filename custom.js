
Blazor.registerCustomEventType('custompaste', {
    browserEventName: 'paste',
    createEventArgs: event => {

        let data = event.clipboardData.getData('text/plain').trim();

        return {
            pastedData: data
        };
    }
});