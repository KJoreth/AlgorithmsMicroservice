
namespace DataStructure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly DataStructureContext _context;
        private readonly IMapper _mapper;
        public DataStructureController(DataStructureContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("Stack")]
        public async Task<ActionResult<StructureDTO>> GetStackAsync()
        {
            var structure = await _context.DataStructures
                                .Where(x => x.Name == "Stack")
                                .FirstOrDefaultAsync();
            return Ok(_mapper.Map<StructureDTO>(structure));
        }
    }
}
