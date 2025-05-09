using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using MediatR;

namespace CleanArchDemo.Applications.Queris.Users
{
    public class GetUserById : IRequest<UserDto>
    {
        public readonly double id;

        public GetUserById(double id)
        {
            this.id = id;
        }
    }
   
}
