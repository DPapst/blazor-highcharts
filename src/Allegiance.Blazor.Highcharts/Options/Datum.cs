﻿namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Datum
    {
        public string Name { get; set; }
        public double? Y { get; set; }
        public string Radius { get; set; }
        public string InnerRadius { get; set; }

        //public string BorderRadius { get; set; }

        public string Color { get; set; }
        public Marker Marker { get; set; }

        public Datum()
        {

        }

        public Datum(string name, double? y, string color = null, string radius = null, string innerRadius = null, Marker marker = null)
        {
            Name = name;
            Y = y;
            Radius = radius;
            InnerRadius = innerRadius;
            Color = color;
            Marker = marker;
        }
    }
}
