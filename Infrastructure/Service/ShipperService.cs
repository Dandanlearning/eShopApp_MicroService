using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Service;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entity;
using AutoMapper;

namespace Infrastructure.Service
{
    public class ShipperService : IShipperService
    {
        private readonly IShipperRepository _shipperrepository;
        private readonly IMapper mapper;

        public ShipperService(IShipperRepository shipperrepository, IMapper mapper)
        {
            _shipperrepository = shipperrepository;
            this.mapper = mapper;
        }
        public async Task<int> AddShipperAsync(ShipperRequestModel model)
        {
            Expression<Func<Shipper, bool>> filter = shipper => shipper.Email == model.Email;
            var existingShipper = await _shipperrepository.GetByConditionAsync(filter);
            if (existingShipper.Any()) {
                throw new Exception("The email is already in use.");
            }
            var newShipper = mapper.Map<Shipper>(model);
            await _shipperrepository.AddAsync(newShipper);
            return newShipper.Id;
        }

        public Task<int> DeleteShipperAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipperResponseModel>> GetAllShippers()
        {
            throw new NotImplementedException();
        }

        public Task<ShipperResponseModel> GetShipperByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipperResponseModel>> GetShipperByRegion(string region)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateShipperAsync(ShipperRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
