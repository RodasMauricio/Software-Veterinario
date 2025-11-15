using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Raza
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Especie Especie { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
