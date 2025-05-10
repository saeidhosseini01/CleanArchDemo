using AutoMapper;
using CleanArchDemo.Applications.Dtos.UserDtos.Users;
using CleanArchDemo.Domain.Entitis.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Mapping
{
    public class MappingsProfile:Profile
    {
        public MappingsProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
                
        }

    }
}
