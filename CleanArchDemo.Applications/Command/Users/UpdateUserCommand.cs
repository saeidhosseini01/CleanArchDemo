using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Domain.ValueObject.Users;
using MediatR;

namespace CleanArchDemo.Applications.Command.Users
{
    public class UpdateUserCommand(Id id, Name name, Age age, Email email) : IRequest<UserDto>
    {
        public int id { get; set; } = id;
        public string name { get; set; } = name;
        public string Email { get; set; } = email;
        public int Age { get; set; } = age

    }
}
