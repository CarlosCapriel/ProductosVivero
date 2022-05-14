using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Services
{
    public interface IServiceLoginAdmin
    {
        int getIdAdmin(string email);
    }
}
