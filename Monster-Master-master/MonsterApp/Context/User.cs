using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonsterApp.Context
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        public int Gold { get; set; }
        public DateTime DateAccountCreated { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
