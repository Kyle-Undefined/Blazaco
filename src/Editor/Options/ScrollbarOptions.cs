namespace Blazaco.Editor.Options
{
    public class ScrollbarOptions
    {
        public int ArrowSize { get; set; } = 11;
        public bool HandleMouseWheel { get; set; } = true;
        public string Horizontal { get; set; } = "auto";
        public bool HorizontalHasArrows { get; set; }
        public int HorizontalScrollbarSize { get; set; } = 10;
        public int HorizontalSliderSize { get; set; }
        public bool UseShadows { get; set; } = true;
        public string Vertical { get; set; } = "auto";
        public bool VerticalHasArrows { get; set; }
        public int VerticalScrollbarSize { get; set; } = 10;
        public int VerticalSliderSize { get; set; }
    }
}
