using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemInformaticaAtelierAuto.Web.Models;

namespace SistemInformaticaAtelierAuto.Web.Data
{
    public class SistemInformaticaAtelierAutoWebContext : DbContext
    {
        public SistemInformaticaAtelierAutoWebContext (DbContextOptions<SistemInformaticaAtelierAutoWebContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Car> Cars { get; set; } = default!;
        public DbSet<Programare> Programari { get; set; } = default!;
    }
}
