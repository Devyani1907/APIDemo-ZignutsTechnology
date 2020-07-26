using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FormDataAPIsProject.Models
{
    public class StudentsDetails
    {
        [Required(ErrorMessage = "Full Name can not be empty")]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Email address is not valid.")]
        public string EmailAddress { get; set; }

        [RegularExpression(@"[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]", ErrorMessage = "Phone Number format should be xxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }

        public string Notes { get; set; }
    }
}
