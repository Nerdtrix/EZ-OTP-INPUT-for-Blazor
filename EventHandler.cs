using Microsoft.AspNetCore.Components;

namespace BlazorApp;


[EventHandler("oncustompaste", typeof(CustomPasteEventArgs), enableStopPropagation: true, enablePreventDefault: true)]

public class CustomPasteEventArgs : EventArgs
{
    // The data here will be supplied by javascript custom.js
    public string? PastedData { get; set; } = string.Empty;
}