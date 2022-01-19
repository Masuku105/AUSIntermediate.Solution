using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }  
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

    }
}
