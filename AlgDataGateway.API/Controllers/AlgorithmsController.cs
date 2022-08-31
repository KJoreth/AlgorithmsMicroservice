using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgDataGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgDataGatewayServices _services;
        public AlgorithmsController(IAlgDataGatewayServices services)
        {
            _services = services;
        }

        [HttpPost("bubbleSort")]
        public async Task<ActionResult<DataSetResponse>> BubbleSortAsync(DataSet data)
        {
            var result = await _services.GetValuesSortedAsync(data, "bubbleSort");
            return Ok(result);
        }
    }
}
