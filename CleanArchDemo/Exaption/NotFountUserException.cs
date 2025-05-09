using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Exaption
{
    public  class NotFountUserException:Exception
    {
        public NotFountUserException(string name, object key)
        : base($"{name} whid {key} was not Fount.") { };
            
        
    }
}
