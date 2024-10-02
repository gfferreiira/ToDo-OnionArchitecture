using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Interfaces
{
    public  interface IChoreRepository
    {
        Task<Chore> GetByIdAsync(int id);
        Task<int> InsertAsync(Chore chore);
        Task<int> UpdateAsync(Chore chore);
        Task<int> DeleteAsync(int id);
    }
}
