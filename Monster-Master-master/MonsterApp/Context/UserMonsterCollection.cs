using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterApp.Context
{
    public class UserMonsterCollection
    {
        [Key]
        public int UserMonsterCollectionId { get; set; }
        public virtual User User { get; set; }
        public virtual Monster Monster { get; set; }
    }
}
