using HelperStockBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Interfaces
{
    internal interface IProductRepository
    {
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products> GetByIdAsync(int? id);
        Task<Products> GetProductCategoryAsync(int? id);
        //CRUD a baixo e a cima assinaturas específicas.
        Task<Products> CreateAsync(Products product);
        Task<Products> UpdateAsync(Products product);
        Task<Products> RemoveAsync(Products product);
    }
}
