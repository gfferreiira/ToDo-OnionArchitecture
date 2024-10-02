using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Interfaces
{
    public interface IUserRepository 
    {
        Task<User> GetByIdAsync(int id);
        Task<int> InsertAsync(User user);
        Task<int> UpdateAsync(User user);
        Task<int> DeleteAsync(int id);

    }
}
