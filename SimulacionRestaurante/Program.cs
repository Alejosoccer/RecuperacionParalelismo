using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SimulacionRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clientes = new List<int>();
            Random cantidadCliente = new Random();
            // Creo al cliente

            for (var i = 0; i < cantidadCliente.Next(10); i++)
            {
                Random cliente = new Random();
                clientes.Add(cliente.Next());
            }

            // Creo un for para simular la llegada de un cliente
            foreach(int cliente in clientes)
            //for (var i = 0; i <+2;i++)
                {
                    Console.WriteLine ("Un cliente ha llegado");
                    //Le doy un nombre al cliente
                    //cliente.Nombre = "Cliente"+i;
                    
                    Console.WriteLine("Bienvenido es un placer pode servirle: "+ cliente);

                    //creo el hilo de atencion1

                    Thread Atencion1 = new Thread(Program.AtencionCliente);
                    //Toma el proceso para la atencion al cliente en la funcion 
                    Atencion1.Start(cliente);

                }
            }
            
           

        private static void AtencionCliente(object cliente)
        {
            var th = Thread.CurrentThread;
            Console.WriteLine("Hilo #{0}", th.ManagedThreadId);

            Console.WriteLine("Bienvenido es un placer pode servirle: " + cliente);
            Console.WriteLine("Puedo tomar su orden" + cliente);
            Console.WriteLine("Le dejo su cuenta por favor" + cliente);
            Console.WriteLine("Fue un placer poder servirle vuelva pronto " + cliente);
            

        }

        //Preceso de atencion al cliente 
      
            
        
             
           


    }
}
