using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevartReproduction.EF
{
    [Table("MODELS")]
    public class Model
    {
        [Key]
        public long ID { get; set; }

        public string DESCRIPTION { get; set; }

        public long CAR_ID { get; set; }
    }
}
