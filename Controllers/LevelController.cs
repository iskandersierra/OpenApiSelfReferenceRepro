using Microsoft.AspNetCore.Mvc;

namespace OpenApiSelfReferenceRepro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LevelController : ControllerBase
    {
        [HttpGet(Name = "GetLevels")]
        public IReadOnlyList<Level1> GetLevels()
        {
            return [];
        }

        [HttpGet("l2", Name = "GetLevels2")]
        public Level1 GetLevels2()
        {
            return new();
        }
    }
}
