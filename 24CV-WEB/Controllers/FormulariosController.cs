using _24CV_WEB.Models;
using _24CV_WEB.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace _24CV_WEB.Controllers
{
    public class FormulariosController : Controller
    {
        private readonly iEmailService _emailService;
        public FormulariosController(iEmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarCorreo(string email, string comentario)
        {

            TempData["Email"] = email;
            TempData["Comentario"] = comentario;

            return View("Index");
         
        }

        //public IActionResult EnviarInformacion(EmailViewModel model) 
        //{
        //    TempData["Email"] = model.Email;
        //    TempData["Comentario"] = model.Comentario;
        //    SendEmail(model.Email, model.Comentario);

        [HttpPost]
        public IActionResult EnviarInformacion(EmailViewModel model)
        {
            TempData["Nombre"] = model.Nombre;
            TempData["Apellido"] = model.Apellido;
            TempData["Email"] = model.Email;
            TempData["FechaNacimiento"] = model.FechaNacimiento;
            TempData["TurnoSelect"] = model.TurnoSelect;
            TempData["Comentario"] = model.Comentario;

            _emailService.SendEmailWithData(
                new EmailData()
                {
                    Email= model.Email,
                    Subject = "Notificación de correo",
                    Content = model.Comentario
                }
                );
            return View("Index", model);
        }


        public bool SendEmail(string email, string Nombre, string Apellido, DateTime FechaNacimiento, Turno TurnoSelect  , string comentario)
        {
            MailMessage mail = new MailMessage();

            SmtpClient smtp = new SmtpClient("mail.shapp.mx", 587);

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");    /* moises.puc @shapp.mx", "Dhaserck_999"
*/
            mail.From = new MailAddress("moises.puc@shapp.mx", "Hacker");
            mail.To.Add(email);
            mail.Subject = "Notificación de contacto.";
            mail.IsBodyHtml = true;
            mail.Body = $"Se ha recibido información del correo <h1>{email}</h1> <br/> <br/> <p>{Nombre}</p> <br/> <p>{Apellido}</p> <br/> <p>{FechaNacimiento}</p> <br/> <p>{TurnoSelect}</p> <br/> <p>{comentario}</p>  ";

            smtp.Send(mail);

            return true;
        }
    }
}

//< p >{ comentario}</ p >