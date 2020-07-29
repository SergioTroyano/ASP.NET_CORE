using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_App.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        { }
    }
}
