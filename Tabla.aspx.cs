using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppWeb
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        public string Numero { get; set; }

        public string Calle { get; set; }

        public string Departamento { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Calle = Request.QueryString["calle"] != null ? Request.QueryString["calle"].ToString() : "";
            //Numero = Request.QueryString["numero"] != null ? Request.QueryString["numero"].ToString() : "";
            Calle = Session["calle"] != null ? Session["calle"].ToString() : "";
            Numero = Session["numero"] != null ? Session["numero"].ToString() : "";
            Departamento = Request.QueryString["departamento"] != null ? Request.QueryString["departamento"].ToString() : "";

            lblDireccionCompleta.Text ="Vives en la calle "+Calle+" numero "+Numero+ " y en el departamento " + Departamento;
        }
    }
}