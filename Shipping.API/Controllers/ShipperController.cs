using ApplicationCore.Interfaces.Service;
using ApplicationCore.Model;
using Infrastructure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shipping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperService _shipperService;
        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }
        [HttpGet]
        public IActionResult GetAllShipper()
        {
            return Ok();
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateShipper(ShipperRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var shipper = await _shipperService.AddShipperAsync(model);
            return Ok(shipper);
            //return CreatedAtAction("GetShipperDetails", new {controller = "shipper", id = shipper}, "Shipper Created");
        }
    }
}
