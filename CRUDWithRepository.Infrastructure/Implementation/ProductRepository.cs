using CRUDWithRepository.Core;
using CRUDWithRepository.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithRepository.Infrastructure.Implementation
{      
    public class ProductRepository:IProductRepository
    {
        private readonly MyAppDbContext _context; 
        public ProductRepository(MyAppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<IProductRepository>> GetAll()
        {
              var  products= await _context.Products.ToListAsync();// Explicit caste
            return (IEnumerable<IProductRepository>)products;
        }

        public Task<Product> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }
        public Task Add(Product Model)
        {
            throw new NotImplementedException();
        }
        public Task Update(Product Model)
        {
            throw new NotImplementedException();
        }
         public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IProductRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
