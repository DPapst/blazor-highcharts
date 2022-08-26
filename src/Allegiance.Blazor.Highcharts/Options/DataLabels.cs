namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class DataLabels
    {
        public string Align { get; set; }
        public bool? AllowOverlap { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public int? BorderRadius { get; set; }
        public int? BorderWidth { get; set; }
        public string Color { get; set; }
        public bool? Crop { get; set; }
        public bool? Enabled { get; set; }
        public string Format { get; set; }
        public bool? Inside { get; set; }
        public string Overflow { get; set; }
        public int? Padding { get; set; }
        public string Position { get; set; }
        public int? Rotation { get; set; }
        public bool? Shaddow { get; set; }
        public string Shape { get; set; }
        public string VerticalAlign { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Z { get; set; }
        public DataLabels()
        {

        }

        public DataLabels(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}
