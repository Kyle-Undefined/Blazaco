using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazaco.Editor
{
	public static class BlazacoJSInterop
    {
		public static Task<bool> InitializeEditor(EditorModel editorModel)
			=> JSRuntime.Current.InvokeAsync<bool>("Blazaco.JSInterop.InitializeEditor", new[] { editorModel });

		public static Task<string> GetValue(string id)
			=> JSRuntime.Current.InvokeAsync<string>("Blazaco.JSInterop.GetValue", new[] { id });

        public static Task<bool> SetValue(string id, string value)
            => JSRuntime.Current.InvokeAsync<bool>("Blazaco.JSInterop.SetValue", new[] { id, value });

        public static Task<bool> SetTheme(string id, string theme)
            => JSRuntime.Current.InvokeAsync<bool>("Blazaco.JSInterop.SetTheme", new[] { id, theme });
    }
}
