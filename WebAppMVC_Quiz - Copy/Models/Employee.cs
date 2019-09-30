using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC_Quiz.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address1 { get; set; }
        [Display(Name = "Complement")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public decimal Salary { get; set; }
    }
}
