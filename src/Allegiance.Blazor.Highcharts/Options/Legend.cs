namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Legend
    {
        public string Align { get; set; }
        public bool? AlignColumns { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public int? BorderRadius { get; set; }
        public int? BorderWidth { get; set; }
        public bool? Enabled { get; set; }
        public bool? Floating { get; set; }
        public int? ItemDistance { get; set; }
        public int? ItemMarginBottom { get; set; }
        public int? ItemMarginTop { get; set; }
        public int? ItemWidth { get; set; }
        public string LabelFormat { get; set; }
        public string Layout { get; set; }
        public int? Margin { get; set; }
        public int? MaxHeight { get; set; }
        public int? Padding { get; set; }
        public bool? Reversed { get; set; }
        public bool? Rtl { get; set; }
        public bool? Shadow { get; set; }
        public bool? SquareSymbol { get; set; }
        public int? SymbolHeight { get; set; }
        public int? SymbolPadding { get; set; }
        public int? SymbolRadius { get; set; }
        public int? SymbolWidth { get; set; }
        public Title Title { get; set; }
        public bool? UseHTML { get; set; }
        public string VerticalAlign { get; set; }
        public int? Width { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }

        public Legend(bool? enabled = null, string layout = null, string align = null, string verticalAlign = null, bool? floating = null, int? x = null, int? y = null, int? borderWidth = null)
        {
            Enabled = enabled;
            Floating = floating;
            Layout = layout;
            Align = align;
            VerticalAlign = verticalAlign;
            X = x;
            Y = y;
            BorderWidth = borderWidth;
        }

        public Legend()
        {

        }
    }
}
