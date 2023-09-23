using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practicaEmpleado.Modelo;

namespace practicaEmpleado.Data
{
    public class practicaEmpleadoContext : DbContext
    {
        public practicaEmpleadoContext (DbContextOptions<practicaEmpleadoContext> options)
            : base(options)
        {
        }

        public DbSet<practicaEmpleado.Modelo.Empleado> Empleado { get; set; } = default!;

        public DbSet<practicaEmpleado.Modelo.Bono>? Bono { get; set; }

    }
}
