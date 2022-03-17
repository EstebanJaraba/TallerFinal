using System;

namespace TallerPoo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var tienda = new Configuración();
            var clienteServicio = new ClienteServicio();
            var productoServicio = new ProductoServicio();
            var reporte = new Reporte();
            var configuración = new Configuración();
            var facturacion = new Facturación();
            bool salir = true;
            while (salir)
            {
                tienda.nombre();
                Console.WriteLine("BIENVENIDO. \n" +
                                "Elija una opción por favor.\n" +
                                " - > 1.Modulo clientes.\n" +
                                " - > 2.Modulo producto\n" +
                                " - > 3.Modulo venta\n" +
                                " - > 4.Modulo reporte\n" +
                                " - > 5.Modulo configuración\n" +
                                " - > 6.Salir\n");

                string elegir = Console.ReadLine();
                Console.Clear();
                switch (elegir)
                {
                    case "1":
                        while (true)
                        {
                            tienda.nombre();
                            string elige1 = "1";
                            string elige2 = "2";
                            string elige3 = "3";
                            string elige4 = "4";
                            string elige5 = "5";
                            Console.WriteLine("Elegiste el modulo clientes.");
                            Console.WriteLine("Bienvenido, que quieres hacer?\n" +
                                            " 1.Registrar clientes\n" +
                                            " 2.Buscar clientes\n" +
                                            " 3.Modificar clientes\n" +
                                            " 4.Deshabilitar clientes\n" +
                                            " 5.salir\n");
                            string opción = Console.ReadLine();
                            Console.Clear();
                            if (opción == elige1)
                            {
                                clienteServicio.agregar();
                            }

                            else if (opción == elige2)
                            {
                                clienteServicio.buscar();
                            }

                            else if (opción == elige3)
                            {
                                clienteServicio.modificar();
                            }

                            else if (opción == elige4)
                            {
                                clienteServicio.deshabilitar();
                            }
                            else break;
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            string elegir1 = "1";
                            string elegir2 = "2";
                            string elegir3 = "3";
                            string elegir4 = "4";
                            string elegir5 = "5";
                            Console.WriteLine("Elegiste el modulo producto.");
                            Console.WriteLine("Bienvenido, que quieres hacer?\n" +
                                            " 1.Registrar producto\n" +
                                            " 2.Buscar producto\n" +
                                            " 3.Modificar producto\n" +
                                            " 4.Deshabilitar producto\n" +
                                            " 5.Salir");
                            var opc = Console.ReadLine();
                            Console.Clear();
                            if (opc == elegir1)
                            {
                                productoServicio.agregar();
                            }

                            else if (opc == elegir2)
                            {
                                productoServicio.buscar();
                            }

                            else if (opc == elegir3)
                            {
                                productoServicio.modificar();
                            }

                            else if (opc == elegir4)
                            {
                                productoServicio.inhabilitar();
                            }
                            else if (opc == elegir5)
                            {
                                break;
                            }
                        }
                        break;
                    case "3":
                        while (true)
                        {
                            string ddd1 = "1";
                            string ddd2 = "2";
                            string ddd3 = "3";
                            Console.WriteLine("MODULO VENTAS");
                            Console.WriteLine(" 1.Venta\n" +
                                              " 2.Buscar factura\n" +
                                              " 3.Salir");
                            var gg = Console.ReadLine();
                            Console.Clear();
                            if (gg == ddd1)
                            {
                                facturacion.facturar();
                            }
                            else if (gg == ddd2)
                            {
                                facturacion.Buscar();
                            }
                            else if (gg == ddd3)
                            {
                                break;
                            }
                        }
                        break;
                    case "4":
                        string ppp1 = "1";
                        string ppp2 = "2";
                        string ppp3 = "3";
                        Console.WriteLine("Reportes.");
                        Console.WriteLine(" 1. Reporte Clientes\n" +
                                        " 2. Reporte producto.\n" +
                                        " 3. Reporte factura.\n");
                        var opcion = Console.ReadLine();
                        if (opcion == ppp1)
                        {
                            reporte.ReporteCliente();

                        }
                        else if (opcion == ppp2)
                        {
                            reporte.ReporteProducto();
                        }
                        else if (opcion == ppp3)
                        {
                            reporte.Reportefactura();
                        }
                        else break;
                    case "5":
                        configuración.nombre();
                        break;
                    case "6":
                        salir = false;
                        break;
                }
            }
        }
    }
}
