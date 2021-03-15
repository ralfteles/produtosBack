using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Repository.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext() { }
            
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) { }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5LI6MQB;Initial Catalog=Produto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");
        }
    }
}
