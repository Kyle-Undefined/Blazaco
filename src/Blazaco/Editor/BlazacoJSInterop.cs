using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazaco.Editor
{
	public static class BlazacoJSInterop
    {
		public static Task<bool> InitializeEditor(IJSRuntime runtime, EditorModel editorModel)
			=> runtime.InvokeAsync<bool>("Blazaco.Editor.InitializeEditor", new[] { editorModel });

		public static Task<string> GetValue(IJSRuntime runtime, string id)
			=> runtime.InvokeAsync<string>("Blazaco.Editor.GetValue", new[] { id });

        public static Task<bool> SetValue(IJSRuntime runtime, string id, string value)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.SetValue", new[] { id, value });

        public static Task<bool> SetTheme(IJSRuntime runtime, string id, string theme)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.SetTheme", new[] { id, theme });

        public static Task<bool> Layout(IJSRuntime runtime, string id)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.Layout", new[] { id });
    }
}
