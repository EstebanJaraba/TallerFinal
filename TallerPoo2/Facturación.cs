using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPoo2
{
    internal class Facturación
    {
        private List<Facturación> listafactura = new();
        public void facturar()
        {
            ProductoServicio productoServicio = new();
            ClienteServicio clienteServicio = new();
            Ventas ventas = new Ventas();
            
            while (true)
            {
                Console.WriteLine("Bienvenido al modulo de ventas.");
                clienteServicio.buscar();
                
                Console.Write("Número de productos que desea llevar:");
                var llevar = int.Parse(Console.ReadLine());
                
                productoServicio.llevarExtra();

                

                Console.WriteLine("Quieres seguir registrando productos en la factura? si o no");
                var opc = Console.ReadLine();
                if (opc != "si")
                {
                    break;
                }
            }
        }
        public void Buscar()
        {
            
        }
    }
}
