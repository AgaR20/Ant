using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Database
{
    public interface IRepository<T> where T: Entity
    {
        Task AddAsync();
        Task UpdateAsync();
        Task RemoveAsync();
        Task<T> GetAsync(int id);
        IQueryable<T> GetAllAsync();
    }
}
