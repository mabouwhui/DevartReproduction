using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devart.Data.Oracle;
using Microsoft.EntityFrameworkCore;

namespace DevartReproduction.EF
{
    public class CarsContext : DbContext
    {

        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
            var oracleMonitor = new OracleMonitor { IsActive = true };
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<ModelVersion> ModelVersions { get; set; }
    }
}
