namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsPie
    {
        public bool? AllowPointSelect { get; set; }

        public bool? ShowInLegend { get; set; }
        public string BorderColor { get; set; }
        public int BorderWidth { get; set; }

        public string Cursor { get; set; }
        public int Depth { get; set; }
        public string[] Center { get; set; }

        public Labels DataLabels { get; set; }

        public States States { get; set; }

        public int? StartAngle { get; set; }
        public int? EndAngle { get; set; }

        public PlotOptionsPie()
        {

        }

        public PlotOptionsPie(bool? allowpointselect = null, bool? showinlegend = null, string cursor = null, Labels datalabels = null, States states = null, int? startangle = null, int? endangle = null)
        {
            AllowPointSelect = allowpointselect;
            ShowInLegend = showinlegend;
            Cursor = cursor;
            DataLabels = datalabels;
            States = states;
            StartAngle = startangle;
            EndAngle = endangle;
        }




    }
}