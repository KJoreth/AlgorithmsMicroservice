namespace AlgorithmsMicroservice.Interfaces
{
    public interface IDataSetResponse
    {
        public List<int> SortedValues { get; set; }
        public float TimeOfCalculation { get; set; }
    }
}
