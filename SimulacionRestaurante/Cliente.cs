

namespace SimulacionRestaurante
{
   public class Cliente: GeneradorClientes
    {
        
        public string Nombre { get; set; }
        public string Orden { get; set; }
        public string Valor { get; set; }

        public string Llegar()
        {
            return "He llegado";
        }
   public string Ordenar()
        {
            return "Deseo Ordenar";
        }
    public string Comer()
        {
            return "Que delicioso esta";
        }

        public string Salir()
        {
            return "Es hora de marcharme";
        }
    
    }
}
