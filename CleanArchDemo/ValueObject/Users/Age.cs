using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.ValueObject.Users
{


    public record Age(double Value) 
    {
        public static implicit operator double(Age age) => age.Value;
    }
}
