namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Buttons
    {
        public ContextButton ContextButton { get; set; }

        public Buttons()
        {

        }

        public Buttons(bool? contextButtonEnabled = null)
        {
            ContextButton = new ContextButton(contextButtonEnabled);
        }
    }
}
