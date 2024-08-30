using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevartReproduction
{
    public class CarDto
    {
        [Key]
        public long ID { get; set; }
        public string Brand { get; set; }
        public bool HasMoreThenOneModel { get; set; }
        public bool HasModels { get; set; }
        public bool isCar { get; set; }
        public bool IsLuxery { get; set; }
    }
}
