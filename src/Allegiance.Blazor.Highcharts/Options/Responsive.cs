using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Responsive
    {
        public List<Rule> Rules { get; set; }

        public Responsive()
        {

        }

        public Responsive(Rule rule)
        {
            Rules = new List<Rule>() { rule };
        }

        public Responsive(List<Rule> rules = null)
        {
            Rules = rules;
        }
    }
}
