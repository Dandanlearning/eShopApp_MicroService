using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shipping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllShipper()
        {
            return Ok();
        }
    }
}
