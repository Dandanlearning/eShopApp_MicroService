using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Entity
{
    [PrimaryKey(nameof(RegionID), nameof(ShipperID))]
    public class ShipperRegion
    {
        [ForeignKey("Region")]
        public int RegionID { get; set; }
        [ForeignKey("Shipper")]
        public int ShipperID { get; set; }
        public Shipper Shipper { get; set; }
        public Region Region { get; set; }
    }
}
