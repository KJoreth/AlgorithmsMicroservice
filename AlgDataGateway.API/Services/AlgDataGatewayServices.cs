
namespace AlgDataGateway.API.Services
{
    public class AlgDataGatewayServices : IAlgDataGatewayServices
    {
        private readonly HttpClient _httpClient;
        public AlgDataGatewayServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
        }
        private async Task<string> ProxyToAsync(string url)
            => await _httpClient.GetStringAsync(url);

        public async Task<StructureDTO> GetStructureAsync(string structure)
        {
            var address = $"https://localhost:7002/api/DataStructure/{structure.FirstCharToUpper()}";
            var response = await ProxyToAsync(address);
            return JsonSerializer.Deserialize<StructureDTO>(response);
        }
    }
}
