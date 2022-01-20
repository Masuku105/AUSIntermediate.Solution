using System.ComponentModel.DataAnnotations;

namespace AUSIntermediate.Solution.Web.MVC.Models
{
    public class AddressModel
    {
        public int AddressId { get; set; }      
        [Required]      
        public string Country { get; set; }
        [Required]
        public string Province { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        [Display(Name = "Postal Code")]
        [Required]
        public string PostalCode { get; set; }
        [Display(Name = "Unit Number")]
        public string UnitNumber { get; set; }
        [Display(Name = "Complex Name")]
        public string ComplexName { get; set; }
        public bool IsResidentialAddress { get; set; }
        public int UserId { get; set; }
        
    }
}
