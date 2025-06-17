using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProyectoNegocio
    {
        public List<Proyecto> listar(int? id = null)
        {
            List<Proyecto> lista = new List<Proyecto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT p.Id, p.Nombre, p.Descripcion, p.ImagenPortada, p.LinkPortfolio,l.Id AS IdLenguaje , l.Nombre AS NombreLenguaje FROM proyectos p LEFT JOIN proyectos_lenguajes pl ON p.Id = pl.IdProyecto LEFT JOIN lenguajes l ON pl.IDLenguaje = l.Id ";
                if (id != null)
                {
                    consulta += "WHERE p.Id="+id;
                }
                consulta += "ORDER BY p.Id";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                Proyecto proyectoActual = null;
                int idProyectoAnterior = -1;

                while (datos.Lector.Read())
                {
                    int idProyecto = (int)datos.Lector["Id"];

                    // Si es un proyecto nuevo (no el mismo que el anterior)
                    if (idProyecto != idProyectoAnterior)
                    {
                        proyectoActual = new Proyecto();

                        proyectoActual.Id = idProyecto;
                        proyectoActual.Nombre = (string)datos.Lector["Nombre"];
                        proyectoActual.Descripcion = (string)datos.Lector["Descripcion"];
                        proyectoActual.UrlImagen = datos.Lector["ImagenPortada"] is DBNull ? null : (string)datos.Lector["ImagenPortada"];
                        proyectoActual.LinkPortfolio = datos.Lector["LinkPortfolio"] is DBNull ? null : (string)datos.Lector["LinkPortfolio"];
                        proyectoActual.Lenguajes = new List<Lenguaje>();

                        idProyectoAnterior = idProyecto;
                        lista.Add(proyectoActual);
                    }

                    proyectoActual.Lenguajes.Add(new Lenguaje
                    {
                        Id = (int)datos.Lector["IdLenguaje"],
                        Nombre = (string)datos.Lector["NombreLenguaje"]
                    });
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
