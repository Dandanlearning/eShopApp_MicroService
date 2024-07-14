using ApplicationCore.Entity;
using ApplicationCore.Model;
using AutoMapper;
namespace Shipping.API
{
    public class ShipperMapper: Profile
    {
        public ShipperMapper() {
            CreateMap<ShipperRequestModel, Shipper>().ReverseMap();
            CreateMap<Shipper, ShipperResponseModel>().ReverseMap();
        }
    }
}
