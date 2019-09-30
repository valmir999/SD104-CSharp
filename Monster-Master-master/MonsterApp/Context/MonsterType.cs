using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MonsterApp.Context
{
    public class MonsterType
    {
        [Key]
        public int MonsterTypeId { get; set; }
        [Required]
        [StringLength(200)]
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}
