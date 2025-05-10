using CleanArchDemo.Domain.Entitis.Users;
using CleanArchDemo.Domain.Exaption;
using CleanArchDemo.Domain.Interface.Users;
using CleanArchDemo.Persistance.DemoDbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Infrastructurs.Repositoris.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly DemoDbContext demoDb;

        public UserRepository(DemoDbContext demoDb )
        {
            this.demoDb = demoDb;
        }
        public async Task AddUserAsync(User user, CancellationToken cancellationToken)
        {
         await  demoDb.Users.AddAsync(user,cancellationToken);
            await demoDb.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
           return await demoDb.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id, CancellationToken cancellationToken)
            => await demoDb.Users.FindAsync(id, cancellationToken);

        public async Task UpdateUserAsync(User user, CancellationToken cancellationToken)
        {
            User olduser = GetUserByIdAsync(user.Id,cancellationToken).Result;
            if(olduser==null) throw new NotFountUserException(user.Name,user.Id);
            olduser.Name=user.Name;
            olduser.Email=user.Email;
            olduser.Age=user.Age;
            demoDb.Users.Update(olduser);
          await  demoDb.SaveChangesAsync(cancellationToken);
        }
    }
}
