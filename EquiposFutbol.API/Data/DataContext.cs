using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EquiposFutbol.Modelos;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<EquiposFutbol.Modelos.Equipo>? Equipo { get; set; } = default!;

        public DbSet<EquiposFutbol.Modelos.Jugador>? Jugador { get; set; }
    }
