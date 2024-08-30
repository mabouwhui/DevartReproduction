using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevartReproduction.EF
{
    [Table("MODELVERSIONS")]
    public class ModelVersion
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("Model")]
        public long MODEL_ID { get; set; }

        [MaxLength(100)]
        public string DESCRIPTION { get; set; }

        public DateTime STARTDATE { get; set; }
        public DateTime? ENDDATE { get; set; }

    }
}
