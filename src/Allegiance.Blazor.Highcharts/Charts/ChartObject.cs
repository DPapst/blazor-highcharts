using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Allegiance.Blazor.Highcharts.Options;
using Microsoft.JSInterop;

namespace Allegiance.Blazor.Highcharts.Charts
{
    public partial class ChartObject : IHighchart
    {
        public Chart Chart { get; set; }

        public Accessibility Accessibility { get; set; }

        public Title Title { get; set; }

        public Title Subtitle { get; set; }

        public XAxis XAxis { get; set; }

        public List<YAxis> YAxis { get; set; }

        public Tooltip Tooltip { get; set; }

        public PlotOptions PlotOptions { get; set; }

        public List<SeriesElement> Series { get; set; }
        public Credits Credits { get; set; }

        public Legend Legend { get; set; }
        public Responsive Responsive { get; set; }
        public Exporting Exporting { get; set; }

        public Pane Pane { get; set; }

        public List<string> Colors { get; set; }

        public ChartObject()
        {
            Chart = new Chart();
            Accessibility = new Accessibility();
            Title = new Title();
            Subtitle = new Title();
            XAxis = new XAxis();
            YAxis = null;
            Tooltip = new Tooltip();
            PlotOptions = new PlotOptions();
            Series = null;
            Credits = new Credits();
            Legend = new Legend();
            Responsive = new Responsive();
            Exporting = new Exporting();
            Pane = new Pane();
        }

        public string Generate()
        {
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault });
            return json.Replace("columnRange", "columnrange");
        }

        public async Task ChangeSeriesAsync(IJSRuntime jsRuntime, string containerId, List<object> newData)
        {
            await jsRuntime.InvokeVoidAsync("updateSeriesHighchartChart", containerId, newData);
        }
        public async Task DestroyAllChartsAsync(IJSRuntime jsRuntime)
        {
            await jsRuntime.InvokeVoidAsync("destroyCharts");
        }
        public async Task ChangeSeriesAtIndexAsync(IJSRuntime jsRuntime, string containerId, int index, List<object> newData)
        {
            await jsRuntime.InvokeVoidAsync("updateSeriesAtIndexHighchartChart", containerId, index, newData);
        }
        public async Task ChangeTitleAsync(IJSRuntime jsRuntime, string containerId, string titleText, string titleColor)
        {
            await jsRuntime.InvokeVoidAsync("updateTitleHighchartChart", containerId, titleText, titleColor);
        }
        public async Task ChangeXAxisPlotlineValAsync(IJSRuntime jsRuntime, string containerId, double plotlineVal, int plotlineIndex = 0)
        {
            await jsRuntime.InvokeVoidAsync("updateXAxisPlotLineValue", containerId, plotlineVal, plotlineIndex);
        }
        public async Task ChangeYAxisPlotlineValAsync(IJSRuntime jsRuntime, string containerId, double plotlineVal, int plotlineIndex = 0)
        {
            await jsRuntime.InvokeVoidAsync("updateYAxisPlotLineValue", containerId, plotlineVal, plotlineIndex);
        }
        public async Task ChangeXAxisCategoriesAsync(IJSRuntime jsRuntime, string containerId, List<double> newCategories)
        {
            await jsRuntime.InvokeVoidAsync("updateXAxisCategories", containerId, newCategories);
        }
        public void DisposeChart(IJSRuntime jsRuntime, string containerId)
        {
            // This is running synchronously, if not triggered it will get handled by JavaScript if the chart already exists.
            jsRuntime.InvokeVoidAsync("disposeHighchartChart", containerId);
        }
    }
}

