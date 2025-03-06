using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmarDireccion_Click(object sender, EventArgs e)
        {
            string calle = tbxCalle.Text;            
            string numero = tbxNumero.Text;
            string departamento = tbxDepartamento.Text;

            Direccion a = new Direccion();
            a.Id =  int.Parse(tbxId.Text);
            a.Calle = tbxCalle.Text;
            a.Numero = int.Parse(tbxNumero.Text);
            a.Departamento = tbxDepartamento.Text;
            a.ColorFachada = tbxColorFachada.Text;

            List<Direccion> temporal = (List<Direccion>)Session["listaDireccion"];
            temporal.Add(a);

            Session.Add("calle",calle);
            Session.Add("numero",numero);

            //Session.Add("0", modificar);
            //Session.Add("0", eliminar);

            Response.Redirect("Tabla.aspx?departamento=" +departamento, false);
        }
    }
}