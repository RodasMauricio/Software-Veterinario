using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NCliente
    {
        public List<Cliente> ListarClientes()
        {
            using (AccesoDatos datos = new AccesoDatos())
            {
                List<Cliente> listaClientes = new List<Cliente>();
                try
                {
                    datos.Consulta("Select C.Id, C.Nombre, C.DNI_CUIT, C.Email, C.Telefono, C.Direccion, C.Localidad, C.Activo From CLIENTES C Where C.Activo = 1");
                    datos.EjecutarConsulta();

                    while (datos.Lector.Read())
                    {
                        Cliente c = new Cliente();
                        c.Id = (int)datos.Lector["Id"];
                        c.Nombre = (string)datos.Lector["Nombre"];
                        c.DniCuit = (string)datos.Lector["DNI_CUIT"];
                        c.Email = (string)datos.Lector["Email"];
                        c.Telefono = (string)datos.Lector["Telefono"];
                        c.Direccion = (string)datos.Lector["Direccion"];
                        c.Localidad = (string)datos.Lector["Localidad"];
                        c.Activo = (bool)datos.Lector["Activo"];
                        listaClientes.Add(c);
                    }
                    return listaClientes;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
