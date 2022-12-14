
namespace Algorithms.API.Data
{
    public class DataSetResponse : IDataSetResponse
    {
        [JsonPropertyName("SortedValues")]
        public List<int> SortedValues { get; set; }
        [JsonPropertyName("TimeOfCalculation")]
        public float TimeOfCalculation { get; set; }
    }
}
