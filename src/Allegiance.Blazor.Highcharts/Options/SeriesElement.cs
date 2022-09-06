using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class SeriesElement
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string FillColor { get; set; }
        public double? FillOpacity { get; set; }
        public double? Opacity { get; set; }
        public Marker Marker { get; set; }
        public List<object> Data { get; set; }
        public bool? ColorByPoint { get; set; }
        public bool? ShowInLegend { get; set; }
        public int? LineWidth { get; set; }
        public string LineColor { get; set; }
        public string DashStyle { get; set; }
        public string Size { get; set; }
        public string InnerSize { get; set; }
        public bool? Visible { get; set; }
        public string Stack { get; set; }
        public Tooltip Tooltip { get; set; }
        public int? YAxis { get; set; }

        public SeriesElement()
        {

        }

        public SeriesElement(string name = null, List<object> data = null, string type = null, bool? colorbypoint = null)
        {
            Name = name;
            Data = data;
            Type = type;
            ColorByPoint = colorbypoint;
        }
    }
}
