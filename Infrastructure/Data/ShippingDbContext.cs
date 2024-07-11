using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ShippingDbContext: DbContext
    {
        public ShippingDbContext(DbContextOptions<ShippingDbContext> option) : base(option)
        {
            
        }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ShipperRegion> ShipperRegions { get; set; }
    }
}
