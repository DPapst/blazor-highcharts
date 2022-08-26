namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Marker
    {
        public bool? Enabled { get; set; }
        public string Symbol { get; set; }
        public int? Radius { get; set; }
        public States States { get; set; }
        public int? LineWidth { get; set; }
        public string LineColor { get; set; }
        public string FillColor { get; set; }

        public Marker()
        {

        }

        public Marker(bool? enabled = null, string symbol = null, int? radius = null, States states = null)
        {
            Enabled = enabled;
            Symbol = symbol;
            Radius = radius;
            States = states;
        }
    }
}