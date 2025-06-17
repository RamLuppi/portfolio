using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class LenguajesNegocio
    {
        public List<Lenguaje> listar()
        {
            List<Lenguaje> lista = new List<Lenguaje>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id,Nombre FROM lenguajes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Lenguaje a = new Lenguaje();

                    a.Id = (int)datos.Lector["Id"];
                    a.Nombre = (string)datos.Lector["Nombre"];

                    lista.Add(a);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
