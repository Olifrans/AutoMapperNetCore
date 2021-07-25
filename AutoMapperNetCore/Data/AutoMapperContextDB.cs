using AutoMapperNetCore.OrigemDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperNetCore.Data
{
    public class AutoMapperContextDB : DbContext
    {
        public AutoMapperContextDB(DbContextOptions options) : base(options)
        {                
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<DetalhesOrder> DetalhesOrders { get; set; }
    }
}
