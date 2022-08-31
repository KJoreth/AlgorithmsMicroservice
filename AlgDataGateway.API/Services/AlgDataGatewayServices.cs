using System.Text;

namespace AlgDataGateway.API.Services
{
    public class AlgDataGatewayServices : IAlgDataGatewayServices
    {
        private readonly HttpClient _httpClient;
        public AlgDataGatewayServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
        }
        private async Task<string> GetProxyToAsync(string url)
            => await _httpClient.GetStringAsync(url);
        private async Task<string> PostProxyToAsync(string url, DataSet data)
        {
            //var jsonObject = JsonSerializer.Serialize(data);
            //var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            //var response = await _httpClient.PostAsync(url, content);
            var response = await _httpClient.PostAsJsonAsync<DataSet>(url, data);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<StructureDTO> GetStructureAsync(string structure)
        {
            var address = $"https://localhost:7002/api/DataStructure/{structure}";
            var response = await GetProxyToAsync(address);
            return JsonSerializer.Deserialize<StructureDTO>(response);
        }

        public async Task<DataSetResponse> GetValuesSortedAsync(DataSet data, string algorithm)
        {
            var address = $"https://localhost:7001/api/Algorithms/{algorithm}";
            var response = await PostProxyToAsync(address, data);
            return JsonSerializer.Deserialize<DataSetResponse>(response);
        }
    }
}
