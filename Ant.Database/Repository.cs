using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant.Database
{
    public class Repository<T>: IRepository<T> where T : Entity
    {
        public virtual async Task AddAsync()
        {

        }

        public virtual async Task UpdateAsync()
        {

        }

        public virtual async Task RemoveAsync()
        {

        }

        public virtual async Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
