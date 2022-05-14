using ProductosVivero.Model;
using ProductosVivero.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Services
{
    public class ImpServiceItems : IserviceItems
    {
        private IntItems _items;
        private ILoginAdminRepository _admin;
        public ImpServiceItems(IntItems items, ILoginAdminRepository admin)
        {
            _items = items;
            _admin = admin;
        }

        public Items[] getProducts(string email)
        {
            int IdProveedor = _admin.getIdAdmin(email);
            return _items.getAllItemsUsers(IdProveedor);
        }

        public Items saveProduct(Items item, string email)
        {
            int idProveedor = _admin.getIdAdmin(email);
            item.IdLoginAdmin = idProveedor;
            return _items.SaveItem(item);
        }
    }
}
