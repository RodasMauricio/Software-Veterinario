using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NPaciente
    {
        public List<Paciente> ListarPacientes()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Paciente> listaPacientes = new List<Paciente>();
                try
                {
                    datos.Consulta("Select P.Id, P.Nombre, E.Id IdEspecie, E.Descripcion Especie, R.Id IdRaza, R.Descripcion Raza, C.Id IdCliente, C.Nombre Cliente, P.FechaNacimiento, P.Sexo, P.ColorPelaje, P.Peso, P.ObservacionesGenerales, P.Activo From PACIENTES P, ESPECIES E, RAZAS R, CLIENTES C Where P.IdEspecie = E.Id and P.IdRaza = R.Id and P.IdCliente = C.Id and P.Activo = 1");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Paciente p = new Paciente();
                        p.Id = (int)datos.Lector["Id"];
                        p.Nombre = (string)datos.Lector["Nombre"];
                        p.Especie = new Especie();
                        p.Especie.Id = (int)datos.Lector["IdEspecie"];
                        p.Especie.Descripcion = (string)datos.Lector["Especie"];
                        p.Raza = new Raza();
                        p.Raza.Id = (int)datos.Lector["IdRaza"];
                        p.Raza.Descripcion = (string)datos.Lector["Raza"];
                        p.Cliente = new Cliente();
                        p.Cliente.Id = (int)datos.Lector["IdCliente"];
                        p.Cliente.Nombre = (string)datos.Lector["Cliente"];
                        if (!(datos.Lector["FechaNacimiento"] is DBNull))
                            p.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                        p.Sexo = (string)datos.Lector["Sexo"];
                        p.ColorPelaje = (string)datos.Lector["ColorPelaje"];
                        p.Peso = (decimal)datos.Lector["Peso"];
                        p.Observacion = (string)datos.Lector["ObservacionesGenerales"];
                        p.Activo = (bool)datos.Lector["Activo"];

                        listaPacientes.Add(p);
                    }
                    return listaPacientes;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Agregar(Paciente p)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Insert into PACIENTES (Nombre, IdEspecie, IdRaza, IdCliente, FechaNacimiento, Sexo, ColorPelaje, Peso, ObservacionesGenerales, Activo)values(@Nombre, @IdEspecie, @IdRaza, @IdCliente, @Fecha, @Sexo, @Color, @Peso, @Observacion, @Activo)");
                    datos.Parametros("@Nombre", p.Nombre);
                    datos.Parametros("@IdEspecie", p.Especie.Id);
                    datos.Parametros("@IdRaza", p.Raza.Id);
                    datos.Parametros("@IdCliente", p.Cliente.Id);
                    datos.Parametros("@Fecha", p.FechaNacimiento);
                    datos.Parametros("@Sexo", p.Sexo);
                    datos.Parametros("@Color", p.ColorPelaje);
                    datos.Parametros("@Peso", p.Peso);
                    datos.Parametros("@Observacion", p.Observacion);
                    datos.Parametros("@Activo", 1);
                    datos.EjecutarComando();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Modificar(Paciente p)
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.Consulta("Update PACIENTES set Nombre = @Nombre, IdEspecie = @IdEspecie, IdRaza = @IdRaza, IdCliente = @IdCliente, FechaNacimiento = @FechaNacimiento, Sexo = @Sexo, ColorPelaje = @Color, Peso = @Peso, ObservacionesGenerales = @Observacion, Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Nombre", p.Nombre);
                    datos.Parametros("@IdEspecie", p.Especie.Id);
                    datos.Parametros("@IdRaza", p.Raza.Id);
                    datos.Parametros("@IdCliente", p.Cliente.Id);
                    datos.Parametros("@FechaNacimiento", p.FechaNacimiento);
                    datos.Parametros("@Sexo", p.Sexo);
                    datos.Parametros("@Color", p.ColorPelaje);
                    datos.Parametros("@Peso", p.Peso);
                    datos.Parametros("@Observacion", p.Observacion);
                    datos.Parametros("@Activo", 1);
                    datos.Parametros("@Id", p.Id);
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
                    datos.Consulta("Update PACIENTES set Activo = @Activo Where Id = @Id");
                    datos.Parametros("@Activo", 0);
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
