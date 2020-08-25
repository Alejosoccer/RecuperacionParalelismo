using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacionRestaurante
{
    public class Mesero
    {

  
        public string Nombre { get; set; }
        public string ClienteAsignado { get; set; }
        public string VerificarCuentaPagada { get; set; }


        public string Saludar()
        {
            return "Muy buenos dias mi nombre es Jose";
        }

        public string TomarPedido()
        {
            return "Le puedo tomar su orden";
        }

        public string DejarCuenta()
        {
            return "SU cuenta es";
        }

        public string Despedirse()
        {
            return "Fue un placer atenderle";
        }
    }
}
