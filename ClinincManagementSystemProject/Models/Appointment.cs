using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        /// <summary>
        /// Foriegn Key doctor Id Referring Doctor Table
        /// </summary>
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }


        [Display(Name = "Specialization Required")]
        [Required]
        public string SpecializationRequired { get; set; }


        /// <summary>
        /// Foreign Key Patient Id Referring Patient Table
        /// </summary>
        [Display(Name ="Patient Id")]
        [Required(ErrorMessage ="Patient Id is Required")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }


        [Required]
        public String DoctorAvailability { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Visit Date is Required")]
        [Display(Name = "Visit Date")]
        public DateTime VisitDate { get; set; }

    }
}
