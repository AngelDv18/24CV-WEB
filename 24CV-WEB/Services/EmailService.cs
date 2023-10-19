using System.Net.Mail;
using System.Net;
using _24CV_WEB.Models;
using System.Linq.Expressions;

namespace _24CV_WEB.Services
{
    public class EmailService : iEmailService
    {
        public bool SendEmail(string email)
        {
            bool result = false;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587); //recibe 2 parametro sirve para llamar el correo
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");  //moises.puc@shapp.mx Dhaserck_999

                mail.From = new MailAddress("moises.puc@shapp.mx", "Hacker");
                mail.To.Add(email);
                mail.Subject = "Notificación de Contacto.";
                mail.IsBodyHtml = true; //informacion que enviamos en en http
                mail.Body = $"Se ha enviado Información del correo <h1>{email}</h1>";

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    

        public bool SendEmailWithData(EmailData data)
        {
            bool result = false;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587); //recibe 2 parametro sirve para llamar el correo
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");  //moises.puc@shapp.mx Dhaserck_999

                mail.From = new MailAddress("moises.puc@shapp.mx", "Hacker");
                mail.To.Add(data.Email);
                mail.Subject = "Notificación de Contacto.";
                mail.IsBodyHtml = true; //informacion que enviamos en en http
                mail.Body = data.Content;

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public bool sendEmailWithoutData(string email)
        {
            throw new NotImplementedException();
        }
    }
}
