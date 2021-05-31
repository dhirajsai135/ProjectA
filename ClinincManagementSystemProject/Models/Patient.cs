using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is Required")]
        [Display(Name ="Gender")]
        public string Gender { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Age is Required")]
        [Display(Name = "Age")]
        public int Age { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date of Birth is Required")]
        public DateTime DateOfBirth { get; set; }

        public IList<Appointment> Appointment { get; set; }
    }
}
