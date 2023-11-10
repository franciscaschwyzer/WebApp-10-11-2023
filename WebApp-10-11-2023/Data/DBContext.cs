using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_10_11_2023.Models;

namespace WebApp_10_11_2023.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp_10_11_2023.Models.Consulta> Consulta { get; set; } = default!;

        public DbSet<WebApp_10_11_2023.Models.Paciente> Paciente { get; set; } = default!;
    }
}
