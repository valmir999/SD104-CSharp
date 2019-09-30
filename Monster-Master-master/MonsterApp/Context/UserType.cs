using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MonsterApp.Context
{
    public class UserType
    {

        [Key]
        public int UserTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }
    }
}
