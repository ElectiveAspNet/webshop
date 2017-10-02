using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models.Entities;
using Webshop.Models.Repositories.Interfaces;

namespace Webshop.Models.Repositories
{
    public class ProductRepository : IProductRepository

    {
        private MyDbContext _db;
        private DbSet<Product> _products;

        public ProductRepository(MyDbContext db)
        {
            _db = db;
            _products = _db.Product;
        }


        public void Create(Product product)
        {
            _db.Add(product);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
