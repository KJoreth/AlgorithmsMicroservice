namespace Algorithms.API.Data
{
    public class DataSetResponse : IDataSetResponse
    {
        public List<int> SortedValues { get; set; }
        public float TimeOfCalculation { get; set; }
    }
}
