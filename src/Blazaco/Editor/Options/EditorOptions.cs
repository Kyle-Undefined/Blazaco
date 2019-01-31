namespace Blazaco.Editor.Options
{
    public class EditorOptions
    {
        public bool AcceptSuggestionOnCommitCharacter { get; set; } = true;
        public string AcceptSuggestionOnEnter { get; set; } = "on";
        public string AccessibilityHelpUrl { get; set; } = "https://go.microsoft.com/fwlink/?linkid=852450%22";
        public string AccessibilitySupport { get; set; } = "auto";
        public string AriaLabel { get; set; }
        public string AutoClosingBrackets { get; set; } = "languageDefined";
        public string AutoClosingQuotes { get; set; } = "languageDefined";
        public bool AutoIndent { get; set; }
        public string AutoSurround { get; set; } = "languageDefined";
        public bool AutomaticLayout { get; set; }
        public bool CodeActionsOnSave { get; set; }
        public int CodeActionsOnSaveTimeout { get; set; }
        public bool CodeLens { get; set; } = true;
        public bool ColorDecorators { get; set; }
        public bool Contextmenu { get; set; } = true;
        public bool CopyWithSyntaxHighlighting { get; set; }
        public string CursorBlinking { get; set; } = "blink";
        public string CursorStyle { get; set; } = "line";
        public int CursorWidth { get; set; } = 0;
        public bool DisableLayerHinting { get; set; }
        public bool DisableMonospaceOptimizations { get; set; }
        public bool DragAndDrop { get; set; }
        public bool EmptySelectionClipboard { get; set; }
        public string ExtraEditorClassName { get; set; }
        public FindOptions Find { get; set; } = new FindOptions();
        public bool FixedOverflowWidgets { get; set; }
        public bool Folding { get; set; } = true;
        public string FoldingStrategy { get; set; } = "auto";
        public string FontFamily { get; set; }
        public bool FontLigatures { get; set; }
        public int FontSize { get; set; }
        public string FontWeight { get; set; } = "normal";
        public bool FormatOnPaste { get; set; }
        public bool FormatOnType { get; set; }
        public bool GlyphMargin { get; set; }
        public bool HideCursorInOverviewRuler { get; set; }
        public bool HighlightActiveIndentGuide { get; set; } = true;
        public HoverOptions Hover { get; set; } = new HoverOptions();
        public bool IconsInSuggestions { get; set; } = true;
        public string Language { get; set; }
        public int LetterSpacing { get; set; }
        public LightbulbOptions Lightbulb { get; set; } = new LightbulbOptions();
        public string LineDecorationsWidth { get; set; } = "10";
        public int LineHeight { get; set; }
        public string LineNumbers { get; set; } = "on";
        public int LineNumbersMinChars { get; set; } = 5;
        public bool Links { get; set; } = true;
        public bool MatchBrackets { get; set; } = true;
        public MinimapOptions Minimap { get; set; } = new MinimapOptions();
        public TextModelOptions TextModel { get; set; } = new TextModelOptions();
        public int MouseWheelScrollSensitivity { get; set; } = 1;
        public bool MouseWheelZoom { get; set; }
        public bool MultiCursorMergeOverlapping { get; set; } = true;
        public string MultiCursorModifier { get; set; } = "alt";
        public bool OccurrencesHighlight { get; set; } = true;
        public bool OverviewRulerBorder { get; set; } = true;
        public int OverviewRulerLanes { get; set; } = 2;
        public ParameterHintOptions ParameterHints { get; set; } = new ParameterHintOptions();
        public bool QuickSuggestions { get; set; } = true;
        public int QuickSuggestionsDelay { get; set; } = 500;
        public bool ReadOnly { get; set; }
        public bool RenderControlCharacters { get; set; }
        public bool RenderIndentGuides { get; set; } = true;
        public string RenderLineHighlight { get; set; } = "all";
        public string RenderWhitespace { get; set; } = "none";
        public int RevealHorizontalRightPadding { get; set; } = 30;
        public bool RoundedSelection { get; set; } = true;
        public int[] Rulers { get; set; }
        public int ScrollBeyondLastColumn { get; set; } = 5;
        public bool ScrollBeyondLastLine { get; set; } = true;
        public ScrollbarOptions Scrollbar { get; set; } = new ScrollbarOptions();
        public bool SelectOnLineNumbers { get; set; } = true;
        public bool SelectionClipboard { get; set; } = true;
        public bool SelectionHighlight { get; set; } = true;
        public string ShowFoldingControls { get; set; } = "mouseover";
        public bool ShowUnused { get; set; }
        public bool SmoothScrolling { get; set; }
        public string SnippetSuggestions { get; set; } = "true";
        public int StopRenderingLineAfter { get; set; } = 10000;
        public SuggestOptions Suggest { get; set; } = new SuggestOptions();
        public int SuggestFontSize { get; set; }
        public int SuggestLineHeight { get; set; }
        public bool SuggestOnTriggerCharacters { get; set; } = true;
        public string SuggestSelection { get; set; }
        public string TabCompletion { get; set; }
        public string Theme { get; set; } = "vs";
        public bool UseTabStops { get; set; }
        public string Value { get; set; }
        public bool WordBasedSuggestions { get; set; } = true;
        public string WordSeparators { get; set; } = "`~!@#$%^&*()-=+[{]}\\|;:\'\",.<>/?";
        public string WordWrap { get; set; } = "off";
        public string WordWrapBreakAfterCharacters { get; set; } = " \t})]?|&,;";
        public string WordWrapBreakBeforeCharacters { get; set; } = "{([+";
        public string WordWrapBreakObtrusiveCharacters { get; set; } = ".";
        public int WordWrapColumn { get; set; } = 80;
        public bool WordWrapMinified { get; set; } = true;
        public string WrappingIndent { get; set; } = "none";
    }
}
