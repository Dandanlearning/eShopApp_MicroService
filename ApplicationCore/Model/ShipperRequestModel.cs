using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model
{
    public class ShipperRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage =("Please enter the name of the shipper"))]
        [StringLength(256, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage =("Please enter the email address"))]
        [MaxLength(255)]
        public string Email { get; set; }
        [RegularExpression(@"^/d{10}$")]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string ContactPerson { get; set; }

    }
}
