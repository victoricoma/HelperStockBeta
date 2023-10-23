using HelperStockBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Interfaces
{
    public interface ICategotegoryRepository
    {
        Task <IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetByIdAsync(int? id);
        //CRUD a baixo e a cima assinaturas específicas.
        Task<Category> CreateAsync(Category category);  
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);


    }
}
