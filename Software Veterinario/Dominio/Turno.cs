using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Veterinario Veterinario { get; set; }
        public Servicio Servicio { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public EstadoTurno Estado { get; set; }
        public string Notas { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
