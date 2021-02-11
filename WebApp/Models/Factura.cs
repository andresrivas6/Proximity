using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Factura
    {
        public Factura()
        {
            cliente = new Cliente();
            articulosFacturas = new HashSet<ArticulosFactura>();
        }

        
        public int id { get; set; }
        public string correl { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }

        public int clienteId { get; set; }
        public Cliente cliente { get; set; }
        public ICollection<ArticulosFactura> articulosFacturas { get; set; }
    }
}
