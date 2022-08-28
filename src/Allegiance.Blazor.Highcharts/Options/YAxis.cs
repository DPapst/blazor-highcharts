using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class YAxis
    {
        public Title Title { get; set; }

        public double? Min { get; set; }

        public Labels Labels { get; set; }
        public string ClassName { get; set; }

        public double? Max { get; set; }

        public int? LineWidth { get; set; }

        public List<object> TickPositions { get; set; }

        public string GridLineColor { get; set; }

        public List<object> Stops { get; set; }

        public List<string> Categories { get; set; }

        public bool Opposite { get; set; }

        public string LineColor { get; set; }
        public List<PlotLine> PlotLines { get; set; }
        public int? GridLineWidth { get; set; }

        public YAxis()
        {
            Title = new Title();
            Labels = new Labels();
            ClassName = null;
        }

        public YAxis(Title title = null, Labels labels = null, string classname = null)
        {
            Title = title;
            Labels = labels;
            ClassName = classname;
        }
    }
}
