using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazaco.Editor
{
	public static class BlazacoJSInterop
    {
		public static Task<bool> InitializeEditor(EditorModel editorModel)
			=> JSRuntime.Current.InvokeAsync<bool>("Blazaco.Editor.InitializeEditor", new[] { editorModel });

		public static Task<string> GetValue(string id)
			=> JSRuntime.Current.InvokeAsync<string>("Blazaco.Editor.GetValue", new[] { id });

        public static Task<bool> SetValue(string id, string value)
            => JSRuntime.Current.InvokeAsync<bool>("Blazaco.Editor.SetValue", new[] { id, value });

        public static Task<bool> SetTheme(string id, string theme)
            => JSRuntime.Current.InvokeAsync<bool>("Blazaco.Editor.SetTheme", new[] { id, theme });
    }
}
