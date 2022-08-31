namespace AlgDataGateway.API.Services
{
    public interface IAlgDataGatewayServices
    {
        Task<StructureDTO> GetStructureAsync(string structure);
    }
}