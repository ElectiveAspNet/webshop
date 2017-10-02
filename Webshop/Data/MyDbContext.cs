using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webshop.Models.Entities;

namespace Webshop.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        
    }
}
