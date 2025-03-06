using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppWeb
{
    public partial class Tabla2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaDireccion"] == null)
            {
                DireccionNegocio direccionNegocio = new DireccionNegocio();
                Session.Add("listaDireccion", direccionNegocio.listar());
            }

            dgvDireccion.DataSource = Session["listaDireccion"];
            dgvDireccion.DataBind();
        }

        protected void btnAgregarDireccionNueva_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagBotones.aspx");
        }

        protected void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            var IdSeleccionado = 1;

            Response.Redirect("PagBotones.aspx?id=" + IdSeleccionado + "modificar=1");
        }

        protected void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            var IdSeleccionado = 1;
            //<div class="modal" tabindex="-1" role="dialog">
            //    <div class="modal-dialog" role="document">
            //        <div class="modal-content">
            //            <div class="modal-header">
            //                <h5 class="modal-title">Modal title</h5>
            //                    <button type = "button" class="close" data-dismiss="modal" aria-label="Close">
            //                        <span aria-hidden="true">&times;</span>
            //                    </button>
            //            </div>
            //            <div class="modal-body">
            //                <p>Modal body text goes here.</p>
            //            </div>
            //            <div class="modal-footer">
            //                <button type = "button" class="btn btn-primary">Save changes</button>
            //                <button type = "button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            //            </div>
            //        </div>
            //    </div>
            //</div>
            
        }

    protected void dgvDireccion_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
}