using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaylandMontalvo_ProyectoCF.Models;

namespace HaylandMontalvo_ProyectoCF.Data
{
    public class HaylandMontalvo_ProyectoCFContext : DbContext
    {
        public HaylandMontalvo_ProyectoCFContext (DbContextOptions<HaylandMontalvo_ProyectoCFContext> options)
            : base(options)
        {
        }

        public DbSet<HaylandMontalvo_ProyectoCF.Models.Burger> Burger { get; set; } = default!;
    }
}
