using ProductosVivero.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Services
{
    public class ImpServiceLoginAdmin : IServiceLoginAdmin
    {
        private ILoginAdminRepository _admin;
        public ImpServiceLoginAdmin(ILoginAdminRepository admin)
        {
            _admin = admin;
        }
        public int getIdAdmin(string email)
        {
            return _admin.getIdAdmin(email);
        }
    }
}
