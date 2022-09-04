namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Title
    {
        public string Text { get; set; }
        public bool? Enabled { get; set; }
        public bool? UseHTML { get; set; }

        public string VerticalAlign { get; set; }
        public string Align { get; set; }

        public bool? Floating { get; set; }

        public Style Style { get; set; }

        public double? Y { get; set; }
        public double? X { get; set; }

        public Title()
        {

        }
        public Title(bool? enabled = null)
        {
            Enabled = enabled;
        }

        public Title(string text = null)
        {
            Text = text;
        }
    }
}
