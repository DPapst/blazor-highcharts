namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsSeries
    {
        public Label Label { get; set; }
        public DataLabels DataLabels { get; set; }
        public Marker Marker { get; set; }
        public double? PointIntervall { get; set; }
        public string PointIntervalUnit { get; set; }
        public double? PointStart { get; set; }
        public double? FillOpacity { get; set; }
        public string Stacking { get; set; }
        public int? PointWidth { get; set; }
        public int? LineWidth { get; set; }
        public string LineColor { get; set; }
        public Animation Animation { get; set; }



        public PlotOptionsSeries()
        {

        }

        public PlotOptionsSeries(Label label = null, double? pointStart = null, int? pointwidth = null)
        {
            Label = label;
            PointStart = pointStart;
            PointWidth = pointwidth;
        }
    }
}
