using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class XAxis
    {
        public Accessibility Accessibility { get; set; }

        public bool? AllowDecimals { get; set; }
        public bool? StartOnTick { get; set; }
        public bool? EendOnTick { get; set; }
        public bool? ShowLastLabel { get; set; }
        public List<double?> TickPositions { get; set; }
        public List<object> Categories { get; set; }
        public int? MinTickInterval { get; set; }
        public int? TickInterval { get; set; }
        public int? MinRange { get; set; }
        public string TickmarkPlacement { get; set; }
        public Labels Labels { get; set; }
        public string Type { get; set; }
        public Title Title { get; set; }
        public List<PlotLine> PlotLines { get; set; }
        public string GridLineColor { get; set; }

        public string LineColor { get; set; }

        public int? GridLineWidth { get; set; }

        public int? LineWidth { get; set; }

        public XAxis()
        {

        }

        public XAxis(Accessibility accessibility = null, bool? allowDecimals = null, bool? startOnTick = null, bool? eendOnTick = null, bool? showLastLabel = null, Labels labels = null, string type = null, Title title = null)
        {
            Accessibility = accessibility;
            AllowDecimals = allowDecimals;
            StartOnTick = startOnTick;
            EendOnTick = eendOnTick;
            ShowLastLabel = showLastLabel;
            Labels = labels;
            Type = type;
            Title = title;
        }

        public XAxis(string type = null)
        {
            Type = type;
        }
    }
}