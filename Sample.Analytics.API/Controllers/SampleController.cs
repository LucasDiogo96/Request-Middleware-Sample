using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sample.Analytics.API.Models;

namespace Sample.Analytics.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class SampleController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromBody] SampleRequestModel model)
        {
            string json = JsonConvert.SerializeObject(model);

            Console.WriteLine(json);

            return Ok();
        }
    }
}
