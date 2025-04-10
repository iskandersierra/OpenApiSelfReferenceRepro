using Microsoft.AspNetCore.Mvc;

namespace OpenApiSelfReferenceRepro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LevelController : ControllerBase
    {
        [HttpGet(Name = "GetLevels")]
        public LevelResponse GetLevels()
        {
            return new();
        }
    }
}
