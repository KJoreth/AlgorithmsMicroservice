using System.Text.Json.Serialization;

namespace DataStructure.API.Data
{
    public class StructureDTO : IStructureDTO
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("BigONotationValue")]
        public string BigONotationValue { get; set; }
    }
}
