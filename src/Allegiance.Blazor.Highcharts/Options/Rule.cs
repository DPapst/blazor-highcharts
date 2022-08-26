namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Rule
    {
        public Condition Condition { get; set; }

        public ChartOptions ChartOptions { get; set; }

        public Rule()
        {

        }

        public Rule(Condition condition = null, ChartOptions chartOptions = null)
        {
            Condition = condition;
            ChartOptions = chartOptions;
        }
    }
}