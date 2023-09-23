using System.ComponentModel.DataAnnotations;

namespace practicaEmpleado.Modelo
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int CI { get; set;}
        public string FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public string cargo { get; set; }
        public int HorasTrabajadas { get; set; }
    }
}
