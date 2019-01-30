namespace Blazaco.Editor.Options
{
    public class EditorOptions
    {
        public bool AcceptSuggestionOnCommitCharacter { get; set; } = true;

        public string Language { get; set; } = string.Empty;
        public string Theme { get; set; } = "vs";
        public string Value { get; set; } = string.Empty;

        public MinimapOptions Minimap { get; set; } = new MinimapOptions();
    }
}
