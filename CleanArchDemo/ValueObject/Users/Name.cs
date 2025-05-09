using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.ValueObject.Users
{


    public record Name(string Value)
    {
        public static implicit operator string(Name name) =>name.Value;

    }                                       
}
