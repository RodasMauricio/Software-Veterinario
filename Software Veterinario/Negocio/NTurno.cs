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
                    datos.Consulta("Select T.Id, P.Id IdPaciente, P.Nombre Paciente, V.Id IdVeterinario, V.Nombre Veterinario, S.Id IdServicio, S.Nombre Servicio, T.FechaHoraInicio, E.Id IdEstado, E.Descripcion Estado, T.NotasInternas From TURNOS T, PACIENTES P, VETERINARIOS V, SERVICIOS S, ESTADOS_TURNO E Where T.IdPaciente = P.Id And T.IdVeterinario = V.Id And T.IdServicio = S.Id And T.IdEstado = E.Id ORDER BY FechaHoraInicio ASC");
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
        
        public void Agregar(Turno t)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into TURNOS (IdPaciente, IdVeterinario, IdServicio, FechaHoraInicio, IdEstado, NotasInternas)values(@IdPaciente, @IdVeterinario, @IdServicio, @Fecha, @IdEstado, @Notas)");
                    datos.Parametros("@IdPaciente", t.Paciente.Id);
                    datos.Parametros("IdVeterinario", t.Veterinario.Id);
                    datos.Parametros("@IdServicio", t.Servicio.Id);
                    datos.Parametros("@Fecha", t.FechaHoraInicio);
                    datos.Parametros("@IdEstado", t.Estado.Id);
                    datos.Parametros("@Notas", t.Notas);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Modificar(Turno t)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update TURNOS set IdPaciente = @IdPaciente, IdVeterinario = @IdVeterinario, IdServicio = @IdServicio, FechaHoraInicio = @Fecha, IdEstado = @IdEstado, NotasInternas = @Notas Where Id = @Id");
                    datos.Parametros("@IdPaciente", t.Paciente.Id);
                    datos.Parametros("IdVeterinario", t.Veterinario.Id);
                    datos.Parametros("@IdServicio", t.Servicio.Id);
                    datos.Parametros("@Fecha", t.FechaHoraInicio);
                    datos.Parametros("@IdEstado", t.Estado.Id);
                    datos.Parametros("@Notas", t.Notas);
                    datos.Parametros("@Id", t.Id);
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
                    datos.Consulta("Delete From TURNOS Where Id = @Id");
                    datos.Parametros("@Id", id);
                    datos.EjecutarConsulta();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    
    }
}
