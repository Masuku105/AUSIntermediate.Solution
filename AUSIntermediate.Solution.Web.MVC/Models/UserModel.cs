using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.Web.MVC.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Your Name Is Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Your Surname Is Required!")]
        public string Surname { get; set; }
        [Display(Name = "Identity Number")]
        [Required(ErrorMessage = "Your ID Number Is Required!")]
        public string IdentityNumber { get; set; }
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Your Date Of Birth Is Required!")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Your Email Address Is Required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Your Email Address Is Required!")]
        [StringLength(10)]
        public string Contact { get; set; }
        public List<AddressModel> Addresses { get; set; }

        public AddressModel PostalAddress { get; set; }
        public AddressModel ResidentialAddress { get; set; }

        public bool IsResidentialAddress { get; set; } 
    }
}
