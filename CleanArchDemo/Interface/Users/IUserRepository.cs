using CleanArchDemo.Domain.Entitis.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Interface.Users
{
    public interface IUserRepository
    {

        Task<List<User>> GetAllUsersAsync(CancellationToken cancellationToken);
        Task<User> GetUserByIdAsync(int id,CancellationToken cancellationToken);
        Task AddUserAsync(User user, CancellationToken cancellationToken);

        Task UpdateUserAsync(User user, CancellationToken cancellationToken);

    }
}
