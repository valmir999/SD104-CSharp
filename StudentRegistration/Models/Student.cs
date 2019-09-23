using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Student
    {

        public int id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string name { get; set; }

        [Display(Name = "Student Cell Phone")]
        public string cellphone { get; set; }
        [Display(Name = "Student Age")]
        public int age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public object ViewBag { get; }

    }
}
