using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Models
{
    public class UserLogin
    {
        [Key]
        public int UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Username is Required")]
        public string Username { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is Required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number is Required")]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }
    }
}
