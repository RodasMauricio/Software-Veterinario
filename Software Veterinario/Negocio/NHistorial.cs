using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NHistorial
    {
        public List<Historial> ListarHistorial()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Historial> listaHistorial = new List<Historial>();
                try
                {
                    datos.Consulta("Select H.Id, T.Id IdTurno, H.MotivoConsulta, H.Diagnostico, H.Tratamiento, H.PrecioFinal From HISTORIAL_MEDICO H, TURNOS T Where H.IdTurno = T.Id");
                    datos.EjecutarConsulta();

                    while (datos.Lector.Read())
                    {
                        Historial h = new Historial();
                        h.Id = (int)datos.Lector["Id"];
                        h.Turno = new Turno();
                        h.Turno.Id = (int)datos.Lector["IdTurno"];
                        h.MotivoConsulta = (string)datos.Lector["MotivoConsulta"];
                        h.Diagnostico = (string)datos.Lector["Diagnostico"];
                        h.Tratamiento = (string)datos.Lector["Tratamiento"];
                        h.PrecioFinal = (decimal)datos.Lector["PrecioFinal"];
                        listaHistorial.Add(h);
                    }
                    return listaHistorial;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
