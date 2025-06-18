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
        private FotosNegocio _fotosNegocio = new FotosNegocio();

        public List<Proyecto> listar(int? id = null)
        {
            List<Proyecto> lista = new List<Proyecto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT p.Id, p.Nombre, p.Descripcion, p.ImagenPortada, p.LinkPortfolio, l.Id AS IdLenguaje, l.Nombre AS NombreLenguaje FROM proyectos p LEFT JOIN proyectos_lenguajes pl ON p.Id = pl.IdProyecto LEFT JOIN lenguajes l ON pl.IDLenguaje = l.Id ";
                if (id != null)
                {
                    consulta += "WHERE p.Id=" + id;
                }
                consulta += " ORDER BY p.Id";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                Proyecto proyectoActual = null;
                int idProyectoAnterior = -1;

                while (datos.Lector.Read())
                {
                    int idProyecto = (int)datos.Lector["Id"];

                    if (idProyecto != idProyectoAnterior)
                    {
                        proyectoActual = new Proyecto
                        {
                            Id = idProyecto,
                            Nombre = (string)datos.Lector["Nombre"],
                            Descripcion = (string)datos.Lector["Descripcion"],
                            UrlImagen = datos.Lector["ImagenPortada"] is DBNull ? null : (string)datos.Lector["ImagenPortada"],
                            LinkPortfolio = datos.Lector["LinkPortfolio"] is DBNull ? null : (string)datos.Lector["LinkPortfolio"],
                            Lenguajes = new List<Lenguaje>(),
                            Fotos = _fotosNegocio.listar(idProyecto) // Cargamos las fotos aquí
                        };

                        idProyectoAnterior = idProyecto;
                        lista.Add(proyectoActual);
                    }

                    // Solo agregamos lenguaje si no es nulo
                    if (!(datos.Lector["IdLenguaje"] is DBNull))
                    {
                        proyectoActual.Lenguajes.Add(new Lenguaje
                        {
                            Id = (int)datos.Lector["IdLenguaje"],
                            Nombre = (string)datos.Lector["NombreLenguaje"]
                        });
                    }
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
