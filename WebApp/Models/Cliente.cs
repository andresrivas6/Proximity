using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Cliente
    {
        public Cliente()
        {
            facturas = new HashSet<Factura>();
        }
        public Cliente(int idCliente)
        {
            facturas = new HashSet<Factura>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public ICollection<Factura> facturas { get; set; }
    }
}
