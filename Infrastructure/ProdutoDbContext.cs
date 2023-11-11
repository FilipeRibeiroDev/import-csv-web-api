using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        public ProdutoDbContext(DbContextOptions options) : base(options) { }
    }
}
