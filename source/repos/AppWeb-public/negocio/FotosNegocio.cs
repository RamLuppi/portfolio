using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class FotosNegocio
    {
        public List<Fotos> listar(int id)
        {
            List<Fotos> lista = new List<Fotos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id,UrlImagen,Titulo FROM proyecto_fotos WHERE ProyectoId=@id");
                datos.setearParametro("@id",id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Fotos a = new Fotos();

                    a.Id = (int)datos.Lector["Id"];
                    a.UrlImagen = (string)datos.Lector["UrlImagen"];
                    a.Titulo = (string)datos.Lector["Titulo"];

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
