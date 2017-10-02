using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models.Entities;
using Webshop.Models.Repositories.Interfaces;

namespace Webshop.Models.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        List<Product> _products = new List<Product>();

        public InMemoryProductRepository()
        {
            _products.Add( new Product{ Id = 1, Name = "Claus", Price = 454 });
        }


        public void Create(Product product)
        {
           // _products.Add(new Product);
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
