using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ArticulosFactura
    {
        public ArticulosFactura()
        {
            factura = new Factura();
            articulo = new Articulo();
        }

        public int id { get; set; }
        public int facturaId { get; set; }
        public Factura factura { get; set; }
        public int articuloId { get; set; }
        public Articulo articulo { get; set; }
        public int cantArticulo { get; set; }
    }
}
