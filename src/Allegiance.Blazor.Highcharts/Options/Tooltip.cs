namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Tooltip
    {
        public bool? Enabled { get; set; }
        public bool? Shared { get; set; }
        public bool? UseHTML { get; set; }
        public string PointFormat { get; set; }
        public string Formatter { get; set; }
        public string HeaderFormat { get; set; }
        public string ValuePrefix { get; set; }
        public bool? Split { get; set; }
        public int? Distance { get; set; }
        public int? Padding { get; set; }
        public string ValueSuffix { get; set; }

        public Tooltip()
        {

        }

        public Tooltip(bool? enabled = null, string pointFormat = null)
        {
            Enabled = enabled;
            PointFormat = pointFormat;
        }
    }
}
