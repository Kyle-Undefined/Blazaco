## Blazaco
A Blazor Component utilizing the Monaco editor by Microsoft, inspired by [BlazorBits](https://github.com/BlazorBits/BlazorBits). Built and tested for Blazor version 0.7.0.

I built this after writing my own ShareX (image / code / link) API in Blazor, just seeing what all it's capable of, and was looking for a way to style the code page. Found the BlazorBits but noticed it wasn't on Nuget anymore and was outdated, so decided to build an updated version. Any feedback would greatly be appreciated.

## Blazor dependencies
* Visual Studio 15.9 or later
* .NET Core 2.1.5 or later

## Usage
* Add the following to your root `_ViewImports.cshtml` file, or any file you want to use the Monaco Editor
```csharp
@using Blazaco.Editor
@addTagHelper *,Blazaco
```

* Add the `MonacoEditor` Component anywhere in your file
```html
<MonacoEditor ref="_editor" Model="@_editorModel" Width="500" Height="500" />

// or

<MonacoEditor ref="_editor" Model="@_editorModel" FullScreen="true" />
```
_Note: You can have a set Width / Height (Defaults to 800 / 600) or have a Fullscreen mode_

* Add your field and property to your `@functions`
```csharp
private EditorModel _editorModel { get; set; }
private MonacoEditor _editor;
```

* Configure Blazaco settings
```csharp
protected override void OnInit()
{
    _editorModel = new EditorModel(); // Uses defaults
}

// or

protected override void OnInit()
{
    _editorModel = new EditorModel()
    {
        Value = "// Your code here"
    };
}

// or

protected override void OnInit()
{
    _editorModel = new EditorModel()
    {
        Value = "// Your code here",
        Minimap = new MinimapOptions()
        {
            Enabled = false
        }
    };
}
```
_Note: You can configure the Constructor Options based on [these](https://microsoft.github.io/monaco-editor/api/interfaces/monaco.editor.ieditorconstructionoptions.html) options_

* Add the `monaco-editor` [folder](https://github.com/Kyle-Undefined/Blazaco/tree/master/monaco-editor) and link the Javascript and CSS files in your `index.html` file
```html
<head>
    <link rel="stylesheet" data-name="vs/editor/editor.main" href="monaco-editor/min/vs/editor/editor.main.css">
</head>
<body>
    <app></app>
    ...
    <link rel="stylesheet" href="//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.12.0/styles/default.min.css">
    <script src="//cdnjs.cloudflare.com/ajax/libs/highlight.js/9.12.0/highlight.min.js"></script>
    <script>var require = { paths: { 'vs': 'monaco-editor/min/vs' } };</script>
    <script src="monaco-editor/min/vs/loader.js"></script>
    <script src="monaco-editor/min/vs/editor/editor.main.nls.js"></script>
    <script src="monaco-editor/min/vs/editor/editor.main.js"></script>
    <script type="blazor-boot">
    </script>
</body>
```

## Interop
Currently I've only created a handful of Methods for Interop, as that's all I really need for my purposes. May add more in the future.

* `InitializeEditor`
  * Internal Method to Initialize the Monaco Editor with default or set settings
* `GetValue`
  * Gets the Value from the Monaco Editor
* `SetValue`
  * Sets the Value for the Monaco Editor to display
* `SetTheme`
  * Sets the Theme for the Monaco Editor

## Copyright
Copyright (c) 2019 Kyle Undefined under the MIT License.