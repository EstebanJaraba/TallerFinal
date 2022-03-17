using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPoo2
{
    internal class ClienteServicio
    {
        private static List<Persona> listaClientes = new();
        public void agregar()
        {
            bool sal = true;
            while (sal)
            {
                Console.WriteLine("REGISTRO CLIENTE");
                Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingese la dirección: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese el número de telefono: ");
                string telefono = Console.ReadLine();
                Console.Write("Digite el número de cédula: ");
                var cedula = Console.ReadLine();

                var persona = new Persona();

                persona.Nombre = nombre;
                persona.Direccion = direccion;
                persona.Telefono = telefono;
                persona.Cedula = cedula;


                listaClientes.Add(persona);
                Console.Clear();
                Console.WriteLine("Quiere seguir registrando clientes?, si-no :");
                var opc = Console.ReadLine();
                Console.Clear();
                if (opc != "si")
                    sal = false;
            }

        }
        public void buscar()
        {
            Console.WriteLine("BUSQUEDA CLIENTE.");
            Console.WriteLine("Escriba el documento del cliente: ");
            var buscar = Console.ReadLine();
            Console.Clear();
            int indice = listaClientes.FindIndex(x => x.Cedula.Contains(buscar));
            if (indice > -1)
            {
                Console.WriteLine("Cliente encontrado!.");
                Console.WriteLine($"Nombre: {listaClientes[indice].Nombre}");
                Console.WriteLine($"Dirección: {listaClientes[indice].Direccion}\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado, no existe\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void modificar()
        {
            Console.WriteLine("MODIFICAR CLIENTE.");
            Console.WriteLine("Escriba el documento del cliente: ");
            var buscar = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingese la dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el número de telefono: ");
            string telefono = Console.ReadLine();
            Console.Clear();
            var persona = new Persona();

            persona.Nombre = nombre;
            persona.Direccion = direccion;
            persona.Telefono = telefono;

            int indice = listaClientes.FindIndex(x => x.Cedula.Contains(buscar));
            listaClientes[indice].Nombre = persona.Nombre;
            listaClientes[indice].Direccion = persona.Direccion;
            listaClientes[indice].Telefono = persona.Telefono;
            if (indice > -1)
            {
                Console.WriteLine($"Nombre: {listaClientes[indice].Nombre}");
                Console.WriteLine($"Dirección: {listaClientes[indice].Direccion} ");
                Console.WriteLine($"Telefono: {listaClientes[indice].Telefono}\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Ingrese los datos bien\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void deshabilitar()
        {
            Console.WriteLine("INHABILITAR CLIENTE");
            Console.WriteLine("ingrese el documento");
            string deshabilitar = Console.ReadLine();
            Console.Clear();
            int indice = listaClientes.FindIndex(x => x.Cedula.Contains(deshabilitar));
            listaClientes.RemoveAt(indice);
            if (indice > -1)
            {
                Console.WriteLine("Eliminado con exito!\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("lo siento, no fue encontrado\n");
                Console.WriteLine("Enter para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void listar()
        {
            Console.WriteLine("Lista de clientes registrados.\n");
            foreach (var producto in listaClientes)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Direccion}");
                Console.WriteLine($"Cantidad: {producto.Telefono}\n");
            }
            Console.WriteLine("Enter para seguir");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
