using ProductosVivero.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Repository
{
    public class ImpLoginAdminRepository : ILoginAdminRepository
    {
        ContextoBd _context;

        public ImpLoginAdminRepository(ContextoBd context)
        {
            _context = context;
        }

        public int getIdAdmin(string email)
        {
            try
            {
                var IdProveedor = _context.LoginAdmin.Where(b => b.Email == email).Select(n => n.Id);
                return IdProveedor.FirstOrDefault();
            }
            catch
            {
                return -1;
            }
        }
    }
}
