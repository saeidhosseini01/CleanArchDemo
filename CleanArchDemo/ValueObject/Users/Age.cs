using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.ValueObject.Users
{


    public record Age(int Value) 
    {
        public static implicit operator int(Age age) => age.Value;
    }
}
