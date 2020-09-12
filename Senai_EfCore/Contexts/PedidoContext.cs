using Microsoft.EntityFrameworkCore;
using Senai_EfCore.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_EfCore.Contexts
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            
                optionsBuilder.UseSqlServer(@"Data Source=N-1S-DEV-16\SQLEXPRESS;Initial Catalog=loja;User ID=sa;Password=sa132");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
