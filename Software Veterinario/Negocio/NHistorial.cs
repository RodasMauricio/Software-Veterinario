using System;
using System.Collections.Generic;
using System.Data;
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

        public void Agregar(Historial h)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                datos.Consulta("Insert into HISTORIAL_MEDICO (IdTurno, MotivoConsulta, Diagnostico, Tratamiento, PrecioFinal)values(@IdTurno, @Motivo, @Diagnostico, @Tratamiento, @Precio)");
                datos.Parametros("@IdTurno", h.Turno.Id);
                datos.Parametros("@Motivo", h.MotivoConsulta);
                datos.Parametros("@Diagnostico", h.Diagnostico);
                datos.Parametros("@Tratamiento", h.Tratamiento);
                datos.Parametros("@Precio", h.PrecioFinal);
                datos.EjecutarComando();
            }
        }

        public void Modificar(Historial h)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update HISTORIAL_MEDICO set IdTurno = @IdTurno, MotivoConsulta = @Motivo, Diagnostico = @Diagnostico, Tratamiento = @Tratamiento, PrecioFinal = @Precio Where Id = @Id");
                    datos.Parametros("@IdTurno", h.Turno.Id);
                    datos.Parametros("@Motivo", h.MotivoConsulta);
                    datos.Parametros("@Diagnostico", h.Diagnostico);
                    datos.Parametros("@Tratamiento", h.Tratamiento);
                    datos.Parametros("@Precio", h.PrecioFinal);
                    datos.Parametros("@Id", h.Id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Eliminar(int id)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Delete From HISTORIAL_MEDICO Where Id = @Id");
                    datos.Parametros("@Id", id);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
