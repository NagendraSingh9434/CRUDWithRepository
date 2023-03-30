using CRUDWithRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithRepository.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
      Task<IEnumerable<Product>>GetAll();
        Task<Product> GetByProductId(int id);
        Task Add(Product Model);
        Task Update(Product Model);
        Task Delete(int id);
    }
}
