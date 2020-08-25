using System;
using System.Collections.Generic;
using System.Threading;

namespace SimulacionRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista para guardar los clientes que ingresaron
           List<int> clientes = new List<int>();
            //Random para especificar los clientes que ingresan
            Random cantidadCliente = new Random();
          // creo el for para llenar la lista con la cantidad de clientes que ingresan
            for (var i = 0; i < cantidadCliente.Next(10); i++)
            {
                //Genera un id aleatorio para el cliente
                Random cliente = new Random();
                //Se agrega el cliente generado a la lista
                clientes.Add(cliente.Next(10));
            }

            // aqui se lee la lista
            foreach(int cliente in clientes)
           
                {
                    Console.WriteLine ("Un cliente ha llegado");
                   
                    Console.WriteLine("Bienvenido es un placer pode servirle: "+ cliente);

                    //creo el hilo para la atencion al cliente

                    Thread atencion = new Thread(Program.AtencionCliente);
                    //Se ejecuta un hilo por cada cliente ingresado 
                    atencion.Start(cliente);

                }
            }
            
           

        private static void AtencionCliente(object cliente)
        {
          // variable para obtener informacion del hilo que se esta ejecutando
            var th = Thread.CurrentThread;
            //Imprime un identificador unico del proceso que se esta ejecutando
            Console.WriteLine("Hilo #{0}", th.ManagedThreadId);

            Console.WriteLine("Bienvenido es un placer pode servirle: " + cliente);
            Console.WriteLine("Puedo tomar su orden" + cliente);
            Console.WriteLine("Le dejo su cuenta por favor" + cliente);
            Console.WriteLine("Fue un placer poder servirle vuelva pronto " + cliente);
            

        }
    }
}
