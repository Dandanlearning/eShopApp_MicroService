using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ShipperRepository : BaseRepository<Shipper>, IShipperRepository
    {
        private readonly ShipperRepository _shipperrepository;
        public ShipperRepository(ShippingDbContext context) : base(context) { }
        //public Task<IEnumerable<Shipper>> GetByRegion(int regionId)
        //{

        //    return
        //}

    }
}
