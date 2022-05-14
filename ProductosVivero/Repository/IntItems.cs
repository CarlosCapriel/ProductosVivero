using ProductosVivero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Repository
{
    public interface IntItems
    {
        public Items SaveItem(Items item);

        public Items[] getAllItemsUsers(int id);

    }
}
