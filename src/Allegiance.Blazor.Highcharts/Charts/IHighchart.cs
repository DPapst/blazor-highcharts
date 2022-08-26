using System.Text.Json;
using System.Text.Json.Serialization;

namespace Allegiance.Blazor.Highcharts.Charts
{
    public interface IHighchart
    {
        string Generate()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault });
        }
    }
}
