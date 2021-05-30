using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is Required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialization is Required")]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name ="Available From")]
        public DateTime AvailableFrom { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Available To")]
        public DateTime AvailableTo { get; set; }

        public IList<Appointment> Appointment { get; set; }
    }
}
