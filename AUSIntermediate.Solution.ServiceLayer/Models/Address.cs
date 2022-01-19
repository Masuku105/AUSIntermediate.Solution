using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string UnitNUmber { get; set; }
        public string ComplexName { get; set; }
        public bool IsResidentialAddress { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }


        
    }
}
