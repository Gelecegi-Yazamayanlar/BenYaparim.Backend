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
        public BenYaparimDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            List<OperationClaim> operationClaims = new List<OperationClaim>()
            {
                new OperationClaim(){Name="Buying",Id=1}, // Alıcı 
                new OperationClaim(){Name="Seller",Id=2}, // Satıcı
                new OperationClaim(){Name="Admin",Id=3}, //  Yönetici
            };

            modelBuilder.Entity<OperationClaim>().HasData(operationClaims);

            base.OnModelCreating(modelBuilder);
        }

    }
}
