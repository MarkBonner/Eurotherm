using System;
using System.ComponentModel.DataAnnotations;

namespace Eurotherm.PatientManagement.Web.Models
{
    public class Patient
    {
        [Required(ErrorMessage="Must be greater than 2 characters")]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage="Must be greater than 3 characters")]
        [MinLength(4)]
        public string Surname { get; set; }

        [Required(ErrorMessage="Must be in the format yyyy-mm-dd")]
        [Display(Name = "Birth date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Dob { get; set; }
        
        public string Note { get; set; }
    }
}