using ProductosVivero.Model;
using ProductosVivero.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Repository
{
    public class ImpItems : IntItems
    {
        ContextoBd _context;
        public ImpItems(ContextoBd context)
        {
            _context = context;
        }

        public Items[] getAllItemsUsers(int id)
        {
            return _context.Items.Where(c => c.IdLoginAdmin == id).ToArray();
        }

        public Items SaveItem(Items item)
        {
            try
            {
                _context.Items.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch
            {
                return null;
            }
        }
    }
}
