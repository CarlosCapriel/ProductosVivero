using ProductosVivero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Services
{
    public interface IserviceItems
    {
        Items[] getProducts(string email);
        Items saveProduct(Items item, string email);
    }
}
