using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WilliamRamirez_Examen1P.Models;

namespace WilliamRamirez_Examen1P.Data
{
    public class WilliamRamirez_Examen1PContext : DbContext
    {
        public WilliamRamirez_Examen1PContext (DbContextOptions<WilliamRamirez_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<WilliamRamirez_Examen1P.Models.WR_jugadores> WR_jugadores { get; set; } = default!;
    }
}
