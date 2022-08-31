using System.Text.Json.Serialization;

namespace AlgDataGateway.API.Data
{
    public class StructureDTO : IStructureDTO
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string BigONotationValue { get; set; }
    }
}
