using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Queris.Users
{
    public class GetAllUserQuery:IRequest<List<UserDto>>;
   
}
