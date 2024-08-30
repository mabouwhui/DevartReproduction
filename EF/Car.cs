using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevartReproduction.EF
{
    [Table("CARS")]
    public class Car
    {
        [Key]
        public long ID { get; set; }

        public string NAME { get; set; }

        [Unicode(false)]
        [MaxLength(1)]
        public string LUXERYBRAND { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
