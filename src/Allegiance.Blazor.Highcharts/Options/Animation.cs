namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Animation
    {
        public int? Duration { get; set; }
        public int? Defer { get; set; }
        public Animation()
        {

        }

        public Animation(int? duration)
        {
            Duration = duration;
        }
    }
}
