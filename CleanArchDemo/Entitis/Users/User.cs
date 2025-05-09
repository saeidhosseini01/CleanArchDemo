using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Entitis.Users
{
    public record User
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Age { get; set; }
    }
}
