using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.BusinessLogicLayer.DTOs
{
    public class AddressDTO
    {
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
        public int CompanyId { get; set; }
    }
}
