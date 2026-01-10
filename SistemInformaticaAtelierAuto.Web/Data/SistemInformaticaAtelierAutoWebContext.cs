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

        public DbSet<SistemInformaticaAtelierAuto.Web.Models.Client> Client { get; set; } = default!;
    }
}
