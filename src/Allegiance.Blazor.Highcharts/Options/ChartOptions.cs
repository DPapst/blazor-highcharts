namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class ChartOptions
    {
        public Legend Legend { get; set; }
        public Title Subtitle { get; set; }

        public ChartOptions()
        {

        }

        public ChartOptions(Legend legend = null)
        {
            Legend = legend;
        }
    }
}