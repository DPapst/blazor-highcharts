namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Hover
    {
        public bool? Enabled { get; set; }
        public bool? Halo { get; set; }
        public string LineColor { get; set; }
        public Marker Marker { get; set; }

        public Hover()
        {

        }

        public Hover(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}