using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.ValueObject.Users
{



    public record Email(string Value)
    {
        public static implicit operator string(Email email)=>email.Value;   
    }
}
