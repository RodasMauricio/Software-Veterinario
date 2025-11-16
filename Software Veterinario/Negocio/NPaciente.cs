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
    }
}
