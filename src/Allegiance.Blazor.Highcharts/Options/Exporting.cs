namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Exporting
    {
        public Buttons Buttons { get; set; }
        public int? SourceWidth { get; set; }
        public int? SourceHeight { get; set; }
        public ChartOptions ChartOptions { get; set; }

        public Exporting(Buttons buttons = null, int? sourceWidth = null, int? sourceHeight = null, ChartOptions chartOptions = null)
        {
            Buttons = buttons;
            SourceWidth = sourceWidth;
            SourceHeight = sourceHeight;
            ChartOptions = chartOptions;
        }

        public Exporting()
        {

        }
    }
}
