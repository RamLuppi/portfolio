using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Proyecto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        public string LinkPortfolio { get; set; }

        public List<Lenguaje> Lenguajes { get; set; }

        public List<Fotos> Fotos { get; set; }
    }
}
