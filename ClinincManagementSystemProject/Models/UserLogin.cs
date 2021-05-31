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
        [StringLength(10, ErrorMessage = "User name must be Six charter long.")]
        public string Username { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "User name must be Six charter long.")]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is Required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number is Required")]
        [Display(Name = "Mobile Number")]
        [StringLength(10, ErrorMessage = "Phone number must be 10 digit.", MinimumLength = 10)]
        public string Mobile { get; set; }
    }
}
