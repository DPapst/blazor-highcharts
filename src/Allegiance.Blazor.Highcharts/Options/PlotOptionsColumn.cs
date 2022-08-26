namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsColumn
    {
        public int? BorderRadius { get; set; }

        public string Stacking { get; set; }

        public PlotOptionsColumn()
        {

        }

        public PlotOptionsColumn(string stacking)
        {
            Stacking = stacking;
        }

        public PlotOptionsColumn(int? borderRadius)
        {
            BorderRadius = borderRadius;
        }
    }
}
