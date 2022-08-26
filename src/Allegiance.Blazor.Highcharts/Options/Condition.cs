namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Condition
    {
        public int? MaxWidth { get; set; }

        public Condition()
        {

        }

        public Condition(int? maxWidth = null)
        {
            MaxWidth = maxWidth;
        }
    }
}