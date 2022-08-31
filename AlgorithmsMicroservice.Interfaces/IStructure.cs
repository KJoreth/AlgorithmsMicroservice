namespace AlgorithmsMicroservice.Interfaces
{
    public interface IStructure
    {
        public int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string BigONotationValue { get; set; }
    }
}
