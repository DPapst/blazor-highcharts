﻿namespace Allegiance.Blazor.Highcharts.Options
{
    public class Options3D
    {
        public bool? Enabled { get; set; }
        public int? Alpha { get; set; }
        public int? Beta { get; set; }

        public Options3D()
        {
        }

        // TODO find another solution here to simplify ctor.
        public Options3D(bool? enabled = null, int? alpha = null, int? beta = null)
        {
            Enabled = enabled;
            Alpha = alpha;
            Beta = beta;
        }
    }
}
