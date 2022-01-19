using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string RegistrationNumber { get; set; }        
        public int BusinessType { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
