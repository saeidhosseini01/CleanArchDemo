using AutoMapper;
using CleanArchDemo.Applications.Command.Users;
using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Domain.Entitis.Users;
using CleanArchDemo.Domain.Interface.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Handlers.Users.CommandHandlers
{
    public class AddUserCommandHandler
        :IRequestHandler<AddUserCommand,UserDto>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public AddUserCommandHandler(IUserRepository userRepository,IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Age = request.Age,
                Email = request.Email,
                Id = request.Id,
                Name = request.Name,
            };
            await userRepository.AddUserAsync(user, cancellationToken);
            return mapper.Map<UserDto>(user);
        }
    }
}
