using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb
{
    public class Direccion
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public string Calle { get; set; }

        public string Departamento { get; set; }

        public string ColorFachada { get; set; }
    }

    public class DireccionNegocio
    {
        public List<Direccion> listar()
        {
            List<Direccion> lista = new List<Direccion>();
            lista.Add(new Direccion());
            lista.Add(new Direccion());

            lista[0].Id = 1;
            lista[0].Numero = 1057;
            lista[0].Calle ="2";
            lista[0].Departamento ="9";
            lista[0].ColorFachada ="Beige";

            lista[1].Id = 2;
            lista[1].Numero =78;
            lista[1].Calle ="Diaz";
            lista[1].Departamento ="-";
            lista[1].ColorFachada ="Blanca";

            return lista;
        }
    }
}