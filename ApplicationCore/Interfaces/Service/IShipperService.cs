using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Service
{
    public interface IShipperService
    {
        Task<int> AddShipperAsync(ShipperRequestModel model);
        Task<int> UpdateShipperAsync(ShipperRequestModel model);
        Task<int> DeleteShipperAsync(int id);
        Task<IEnumerable<ShipperResponseModel>> GetAllShippers();
        Task<ShipperResponseModel> GetShipperByIdAsync(int id);
        Task<IEnumerable<ShipperResponseModel>> GetShipperByRegion(string region);
    }
}
