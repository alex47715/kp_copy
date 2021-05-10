using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Entity
{
    public interface IPrototype
    {
        bool Status();
        IPrototype Clone(string username, string email, string password);
    }
}
