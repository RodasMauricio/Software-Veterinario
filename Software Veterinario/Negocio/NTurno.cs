using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NTurno
    {
        public List<Turno> ListarTurnos()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Turno> listaTurnos = new List<Turno>();
                try
                {
                    datos.Consulta("Select T.Id, P.Id IdPaciente, P.Nombre Paciente, V.Id IdVeterinario, V.Nombre Veterinario, S.Id IdServicio, S.Nombre Servicio, T.FechaHoraInicio, E.Id IdEstado, E.Descripcion Estado, T.NotasInternas From TURNOS T, PACIENTES P, VETERINARIOS V, SERVICIOS S, ESTADOS_TURNO E Where T.IdPaciente = P.Id And T.IdVeterinario = V.Id And T.IdServicio = S.Id And T.IdEstado = E.Id");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Turno t = new Turno();
                        t.Id = (int)datos.Lector["Id"];
                        t.Paciente = new Paciente();
                        t.Paciente.Id = (int)datos.Lector["IdPaciente"];
                        t.Paciente.Nombre = (string)datos.Lector["Paciente"];
                        t.Veterinario = new Veterinario();
                        t.Veterinario.Id = (int)datos.Lector["IdVeterinario"];
                        t.Veterinario.Nombre = (string)datos.Lector["Veterinario"];
                        t.Servicio = new Servicio();
                        t.Servicio.Id = (int)datos.Lector["IdServicio"];
                        t.Servicio.Nombre = (string)datos.Lector["Servicio"];
                        if (!(datos.Lector["FechaHoraInicio"] is DBNull))
                            t.FechaHoraInicio = (DateTime)datos.Lector["FechaHoraInicio"];
                        t.Estado = new EstadoTurno();
                        t.Estado.Id = (int)datos.Lector["IdEstado"];
                        t.Estado.Descripcion = (string)datos.Lector["Estado"];
                        if (!(datos.Lector["NotasInternas"] is DBNull))
                            t.Notas = (string)datos.Lector["NotasInternas"];
                        listaTurnos.Add(t);
                    }
                    return listaTurnos;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
