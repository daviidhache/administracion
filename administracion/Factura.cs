using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion
{
    internal class Factura
    {
        String producto;
        String proveedor;
        int stock;

        public Factura() { 
            
        }

        public string Producto { get => producto; set => producto = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
