using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazaco.Editor
{
	public static class BlazacoInterop
    {
		public static Task<bool> InitializeEditor(EditorModel editorModel)
			=> JSRuntime.Current.InvokeAsync<bool>("BlazacoFunctions.InitializeEditor", new[] { editorModel });

		public static Task<EditorModel> GetValue(EditorModel editorModel)
			=> JSRuntime.Current.InvokeAsync<EditorModel>("BlazacoFunctions.GetValue", new[] { editorModel });

        public static Task<EditorModel> SetValue(EditorModel editorModel)
            => JSRuntime.Current.InvokeAsync<EditorModel>("BlazacoFunctions.SetValue", new[] { editorModel });

        public static Task<EditorModel> SetTheme(EditorModel editorModel)
            => JSRuntime.Current.InvokeAsync<EditorModel>("BlazacoFunctions.SetTheme", new[] { editorModel });
    }
}
