using AutoMapper;
using CleanArchDemo.Applications.Command.Users;
using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Domain.Entitis.Users;
using CleanArchDemo.Domain.Exaption;
using CleanArchDemo.Domain.Interface.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Handlers.Users.CommandHandlers
{
    public class UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        : IRequestHandler<UpdateUserCommand, UserDto>
    {
        public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var oldUser = await userRepository.GetUserByIdAsync(request.id, cancellationToken);
            if(oldUser==null) throw new NotFountUserException(nameof(oldUser), request.id);


            await userRepository.UpdateUserAsync(new User
            {
                Id = request.id,
                Age = request.Age,
                Email = request.Email,
                Name = request.name
            },cancellationToken);
            var newUser = userRepository.GetUserByIdAsync(request.id, cancellationToken);
            return mapper.Map<UserDto>(newUser);
        }
    }
}
