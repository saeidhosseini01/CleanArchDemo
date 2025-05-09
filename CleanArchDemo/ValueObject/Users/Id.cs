using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.ValueObject.Users
{



    public record Id(double Value)
    {
        public static implicit operator double(Id id) => id.Value;
    }
}
