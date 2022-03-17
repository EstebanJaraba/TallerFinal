using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPoo2
{
    internal class Reporte
    {
        public void ReporteCliente()
        {
            ClienteServicio clienteServicio = new();
            clienteServicio.listar();
        }
        public void ReporteProducto()
        {
            ProductoServicio producto = new();
            producto.listar();
        }
        public void Reportefactura()
        {

        }
    }
}
