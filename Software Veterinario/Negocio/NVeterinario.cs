using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NVeterinario
    {
        public List<Veterinario> ListarVeterinarios()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Veterinario> listaVeterinarios = new List<Veterinario>();
                try
                {
                    datos.Consulta("Select V.Id, V.Nombre, V.Matricula, V.Email, V.Telefono From VETERINARIOS V");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Veterinario v = new Veterinario();
                        v.Id = (int)datos.Lector["Id"];
                        v.Nombre = (string)datos.Lector["Nombre"];
                        v.Matricula = (string)datos.Lector["Matricula"];
                        v.Email = (string)datos.Lector["Email"];
                        v.Telefono = (string)datos.Lector["Telefono"];
                        listaVeterinarios.Add(v);
                    }
                    return listaVeterinarios;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
