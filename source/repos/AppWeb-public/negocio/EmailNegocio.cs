using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace negocio
{
    public class EmailNegocio
    {
        private SmtpClient server;
        private MailMessage email;

        public EmailNegocio()
        {

            server = new SmtpClient();
            server.Credentials = new NetworkCredential("X", "XX");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarMail(string EmailContacto, string nombre, string mensaje)
        {
            email = new MailMessage();
            email.From = new MailAddress("X");
            email.To.Add("Mi mail");
            string cuerpo = "Nuevo envio de correo electronico por cuestionario. El mail del contacto es " + EmailContacto + " . El nombre: " + nombre + " . Y el mensaje que ha dejado: " + mensaje + " .";
            email.Body = cuerpo;
        }

        public void enviarMail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
