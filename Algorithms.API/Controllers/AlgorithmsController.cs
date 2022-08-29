using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly IAlgorithmsServices _services;
        public AlgorithmsController(IAlgorithmsServices services)
            => _services = services;

        [HttpPost("BubbleSort")]
        public ActionResult<DataSetResponse> BubbleSort(DataSet data)
            => Ok(_services.BubbleSort(data));

    }
}
