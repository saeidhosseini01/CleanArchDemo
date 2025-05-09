using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Domain.ValueObject.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Command.Users
{
    public class AddUserCommand(Id id,Name name,Age age,Email email):IRequest<UserDto>
    {
        public double Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public Double Age { get; set; } = age;

    }
}
