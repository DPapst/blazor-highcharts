namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class ContextButton
    {
        public bool? Enabled { get; set; }

        public ContextButton(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }

}
