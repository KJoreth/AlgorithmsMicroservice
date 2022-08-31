namespace AlgDataGateway.API.Services
{
    public interface IAlgDataGatewayServices
    {
        Task<StructureDTO> GetStructureAsync(string structure);
        Task<DataSetResponse> GetValuesSortedAsync(DataSet data, string algorithms);
    }
}