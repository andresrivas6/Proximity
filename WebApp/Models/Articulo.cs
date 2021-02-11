using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Articulo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public ICollection<ArticulosFactura> articulosFacturas { get; set; }
    }
}
