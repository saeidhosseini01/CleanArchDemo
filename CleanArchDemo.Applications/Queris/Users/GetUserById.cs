using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using MediatR;

namespace CleanArchDemo.Applications.Queris.Users
{
    public class GetUserById : IRequest<UserDto>
    {
        public readonly int id;

        public GetUserById(int id)
        {
            this.id = id;
        }
    }
   
}
