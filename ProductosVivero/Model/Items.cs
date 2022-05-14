using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.Model
{
    public class Items
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Decimal Price { get; set; }

        public string? Description { get; set; }

        public int IdLoginAdmin { get; set; }

        public string? category { get; set;}
    }
}
