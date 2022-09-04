namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsArea
    {
        public double? PointStart { get; set; }
        public string Stacking { get; set; }
        public int? LineWidth { get; set; }
        public string LineColor { get; set; }
        public Marker Marker { get; set; }
        public DataLabels DataLabels { get; set; }
        public bool? EnableMouseTracking { get; set; }

        public PlotOptionsArea()
        {

        }

        public PlotOptionsArea(double? pointStart = null, Marker marker = null)
        {
            PointStart = pointStart;
            Marker = marker;
        }
    }
}
