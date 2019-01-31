namespace Blazaco.Editor.Options
{
    public class SuggestOptions
    {
        public bool FilterGraceful { get; set; } = true;
        public bool LocalityBonus { get; set; }
        public bool SnippetsPreventQuickSuggestions { get; set; } = true;
    }
}
