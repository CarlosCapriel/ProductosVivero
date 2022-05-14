using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Repository
{
    public interface ILoginAdminRepository
    {
        int getIdAdmin(string email);
    }
}
