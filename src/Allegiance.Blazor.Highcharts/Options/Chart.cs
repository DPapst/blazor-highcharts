using System.Collections.Generic;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Chart
    {
        public string Type { get; set; }
        public bool? StyledMode { get; set; }
        public string ZoomType { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public List<int?> Spacing { get; set; }

        public List<int?> Margin { get; set; }

        public object BackgroundColor { get; set; }

        public Animation Animation { get; set; }

        public Options3D Options3d { get; set; }


        public Chart(string type = null, bool? styledMode = null, string zoomType = null, int? width = null, int? height = null, List<int?> spacing = null, List<int?> margin = null, object backgroundColor = null, Animation animation = null, Options3D options3d = null)
        {
            Type = type;
            StyledMode = styledMode;
            ZoomType = zoomType;
            Width = width;
            Height = height;
            Spacing = spacing;
            Margin = margin;
            BackgroundColor = backgroundColor;
            Animation = animation;
            Options3d = options3d;
        }

        public Chart()
        {

        }
    }
}
