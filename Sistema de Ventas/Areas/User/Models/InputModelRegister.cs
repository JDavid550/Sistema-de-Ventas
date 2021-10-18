using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Ventas.Areas.User.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "This field is mandatory")]
        public string name { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Please submit yout ID number")]
        public string NID { get; set; }

        [Required(ErrorMessage = "Please submit your phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage ="The phone number format is not correct")]

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please submit your email")]
        [EmailAddress(ErrorMessage ="The email is not valid")]
        public string email { get; set; }

        [Required(ErrorMessage = "Setting a password is mandatory")]
        [StringLength(20, ErrorMessage ="Your password must contain at least {2} characters", MinimumLength = 6)]
        public string password { get; set; }

    }
}
