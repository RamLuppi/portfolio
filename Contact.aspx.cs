using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace AppWeb
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles
                string nombre = txtNombre.Text;
                string email = txtEmail.Text;
                string mensaje = txtMensaje.Text;

                // Configurar el correo electrónico
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("amiroluppi1212@hotmail.com"); // Correo del remitente
                mail.To.Add("ramiro_luppi@hotmail.com"); // Correo del destinatario
                mail.Subject = "Nuevo mensaje de contacto"; // Asunto del correo
                mail.Body = $"Nombre: {nombre}\nEmail: {email}\nMensaje: {mensaje}"; // Cuerpo del correo

                // Configurar el servidor SMTP
                SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpHost"]); // Servidor SMTP
                smtpClient.Port = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]); // Puerto SMTP
                smtpClient.Credentials = new NetworkCredential(
                    ConfigurationManager.AppSettings["SmtpUser"], // Usuario: "apikey"
                    ConfigurationManager.AppSettings["SmtpPassword"] // Contraseña: Clave de API
                );
                smtpClient.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["EnableSsl"]); // Habilitar SSL

                // Enviar el correo
                smtpClient.Send(mail);

                // Mostrar mensaje de éxito
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Mensaje enviado con éxito');", true);

                // Limpiar los campos después del envío (opcional)
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtMensaje.Text = "";
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", $"alert('Error al enviar el mensaje: {ex.Message}');", true);
            }
        }
    }
}