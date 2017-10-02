using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models.Entities;

namespace Webshop.Models.Repositories.Interfaces
{
    public interface IProductRepository
    {
        // CRUD
        void Create(Product product);
        IEnumerable<Product> ReadAll();
        Product Read(int id);
        void Update(Product product);
        void Delete(int id);
        
    }
}
