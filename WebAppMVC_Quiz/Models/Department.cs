using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC_Quiz.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Manager { get; set; }
        [Required]
        [Display(Name = "Ext.")]
        public int ExtensionNumber { get; set; }
        public string Email { get; set; }
        public object ViewBag { get; }
    }
}
