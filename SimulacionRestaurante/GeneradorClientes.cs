using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacionRestaurante
{
    public class GeneradorClientes
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public GeneradorClientes()
        {
            Id = random.Next();
        }

        public GeneradorClientes(int identificador)
        {
            Id = identificador;
        }

        public GeneradorClientes(string identificadorCadena)
        {
            Id = Convert.ToInt32(identificadorCadena);
        }
    }
}
