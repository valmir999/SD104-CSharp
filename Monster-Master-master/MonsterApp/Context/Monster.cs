using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonsterApp.Context
{
    public class Monster
    {
        [Key]
        public int MonsterId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public virtual MonsterType MonsterType { get; set; }
    }
}
