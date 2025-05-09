using AutoMapper;
using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Applications.Queris.Users;
using CleanArchDemo.Domain.Exaption;
using CleanArchDemo.Domain.Interface.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Handlers.Users.QuerisHandlers
{
    public class GetUserByIdQueryHandler:IRequestHandler<GetUserById,UserDto>

    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetUserByIdQueryHandler(IUserRepository userRepository ,IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.id, cancellationToken);
            if (user == null) throw new NotFountUserException(nameof(user), request.id);
            return mapper.Map<UserDto>(user);
        }
    }
}
