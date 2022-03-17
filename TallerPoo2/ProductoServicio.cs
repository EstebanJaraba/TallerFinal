using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPoo2
{
    internal class ProductoServicio
    {
        private static List<Producto> listaProducto = new();
        public void agregar()
        {
            var id = 1;
            bool sal = true;
            while (sal)
            {
                Console.WriteLine("REGISTRO PRODUCTO");
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingese el precio: ");
                var precio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad: ");
                var cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el codigo del producto: ");
                var codigo = int.Parse(Console.ReadLine());
                Console.Clear();

                var producto = new Producto();

                producto.Nombre = nombre;
                producto.Precio = precio;
                producto.Cantidad = cantidad;
                producto.Código = codigo;


                listaProducto.Add(producto);

                Console.WriteLine("Quiere seguir registrando productos?, si-no :");
                var opc = Console.ReadLine();
                Console.Clear();
                if (opc != "si")
                    sal = false;
            }
        }
        public void llevarExtra()
        {
            Ventas ventas = new();
            Console.WriteLine("BUSQUEDA PRODUCTOS");
            Console.WriteLine("Escriba el codigo del producto: ");
            var buscar = int.Parse(Console.ReadLine());

            int indice = listaProducto.FindIndex(a => a.Código.Equals(buscar));
            if (indice > -1)
            {
                Console.WriteLine("Producto encontrado, si existe.");
                Console.WriteLine($"Nombre: {listaProducto[indice].Nombre}");
                Console.WriteLine($"Precio: {listaProducto[indice].Precio}\n");

                Console.WriteLine("Lista de productos registrados.\n");
                foreach (var producto in listaProducto)
                {
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Precio: {producto.Precio}");
                    Console.WriteLine($"Cantidad: {producto.Cantidad}\n");
                }
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("El producto no fue encontrado o no existe.");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }

            ProductoServicio productoServico = new();
            Console.Write("Que cantidades deseas llevar?: ");
            var llevar = int.Parse(Console.ReadLine());
            if (llevar > listaProducto[indice].Cantidad)
            {
                Console.WriteLine("No contamos con la cantidad suficiente al pepido.");
            }
            else
            {
                int total = listaProducto[indice].Cantidad - llevar;
                int totalPrecio = listaProducto[indice].Precio * llevar;

                Console.WriteLine("Se pudo realizar el pedido exitosamente!.");
                Console.WriteLine($"Su valor total a pagar es: {totalPrecio}");
                Console.WriteLine($"Cantidad del producto siponible: {total}");

                var contarId = 1;
                List<Persona> listaClientes = new();
                Facturación facturación = new();
                ventas.Factura = contarId;
                contarId++;
                ventas.Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                Console.WriteLine($"Número de factura: {ventas.Factura}");
                foreach (var persona in listaClientes)
                {
                    Console.WriteLine($"Cedula: {persona.Cedula}");
                }
                Console.WriteLine($"Fecha {ventas.Fecha}");
                Console.WriteLine($"Valor total: {totalPrecio}");
                Console.WriteLine("Detalle factura");
                foreach (var producto in listaProducto)
                {
                    Console.WriteLine($"Producto: {producto.Nombre}");
                }
                Console.WriteLine($"Cantidad: {llevar}");
            }
            
        }
        public void buscar()
        {
            Console.WriteLine("BUSQUEDA PRODUCTOS");
            Console.WriteLine("Escriba el codigo del producto: ");
            var buscar = int.Parse(Console.ReadLine());

            int indice = listaProducto.FindIndex(a => a.Código.Equals(buscar));
            if (indice > -1)
            {
                Console.WriteLine("Producto encontrado, si existe.");
                Console.WriteLine($"Nombre: {listaProducto[indice].Nombre}");
                Console.WriteLine($"Precio: {listaProducto[indice].Precio}\n");

                Console.WriteLine("Lista de productos registrados.\n");
                foreach (var producto in listaProducto)
                {
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Precio: {producto.Precio}");
                    Console.WriteLine($"Cantidad: {producto.Cantidad}\n");
                }
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("El producto no fue encontrado o no existe.");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void modificar()
        {
            Console.WriteLine("MODIFICAR PRODUCTOS");
            Console.WriteLine("Escriba el codigo del producto: ");
            var buscar = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad: ");
            var cantidad = int.Parse(Console.ReadLine());
            Console.Clear();
            var producto = new Producto();

            producto.Nombre = nombre;
            producto.Cantidad = cantidad;

            int indice = listaProducto.FindIndex(a => a.Código.Equals(buscar));
            listaProducto[indice].Nombre = producto.Nombre;
            listaProducto[indice].Cantidad = producto.Cantidad;
            if (indice > -1)
            {
                Console.WriteLine("Producto modificado!:");
                Console.WriteLine($"Nombre: {listaProducto[indice].Nombre}");
                Console.WriteLine($"Cantidad: {listaProducto[indice].Cantidad}\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Producto a modificar no encontrado o no existe.");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void inhabilitar()
        {
            Console.WriteLine("INHABILITAR PRODUCTO");
            Console.WriteLine("ingrese el codigo del producto que desea eliminar: ");
            var inhabilitar = int.Parse(Console.ReadLine());
            Console.Clear();
            int indice = listaProducto.FindIndex(a => a.Código.Equals(inhabilitar));
            listaProducto.RemoveAt(indice);
            if (indice > -1)
            {
                Console.WriteLine("Eliminado con exito!.");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No se pudo eliminar el producto porque no se encontro.\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void listar()
        {
            Console.WriteLine("Lista de productos registrados.\n");
            foreach (var producto in listaProducto)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Precio}");
                Console.WriteLine($"Cantidad: {producto.Cantidad}\n");
            }
            Console.WriteLine("Enter para seguir");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
