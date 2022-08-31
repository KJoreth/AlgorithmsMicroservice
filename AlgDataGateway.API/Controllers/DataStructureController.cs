using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgDataGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly IAlgDataGatewayServices _services;
        public DataStructureController(IAlgDataGatewayServices services)
        {
            _services = services;
        }

        [HttpGet("Stack")]
        public async Task<ActionResult<StructureDTO>> GetStackAsync()
        {
            var result = await _services.GetStructureAsync("stack");
            return Ok(result);
        }
    }
}
