using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class BenYaparimDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C964S3Q;Database=BenYaparim.Onion; Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
