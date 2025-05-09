using AutoMapper;
using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Applications.Queris.Users;
using CleanArchDemo.Domain.Interface.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Handlers.Users.QuerisHandlers
{
    public class GetAllUserQueryHandler 
        : IRequestHandler<GetAllUserQuery, List<UserDto>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetAllUserQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users =await userRepository.GetAllUsersAsync(cancellationToken);
            return mapper.Map<List<UserDto>>(users);
           
        }
    }
}
