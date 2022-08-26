namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptions
    {
        public PlotOptionsSeries Series { get; set; }

        public PlotOptionsArea Area { get; set; }
        public PlotOptionsBar Bar { get; set; }

        public PlotOptionsPie Pie { get; set; }
        public PlotOptionsScatter Scatter { get; set; }

        public PlotOptionsColumn Column { get; set; }
        public PlotOptionsColumnRange ColumnRange { get; set; }
        public PlotOptionsLine Line { get; set; }
        public PlotOptionsSpline Spline { get; set; }

        public PlotOptionsSolidgauge Solidgauge { get; set; }



        public PlotOptions()
        {
            Series = new PlotOptionsSeries();
        }

        public PlotOptions(PlotOptionsSeries series = null)
        {
            Series = series;
        }
        public PlotOptions(PlotOptionsSeries series = null, PlotOptionsArea area = null)
        {
            Series = series;
            Area = area;
        }
        public PlotOptions(PlotOptionsSeries series = null, PlotOptionsPie pie = null)
        {
            Series = series;
            Pie = pie;
        }

        public PlotOptions(PlotOptionsSeries series = null, PlotOptionsColumn column = null)
        {
            Series = series;
            Column = column;
        }
    }
}
