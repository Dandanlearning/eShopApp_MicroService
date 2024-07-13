using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IShipperRepository: IBaseRepository<Shipper>
    {
        //Task<IEnumerable<Shipper>> GetByRegion(int regionId);
    }
}
