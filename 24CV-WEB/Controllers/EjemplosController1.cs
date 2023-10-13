using _24CV_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24CV_WEB.Controllers
{
    public class EjemplosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Angel";
            persona.Apellidos = "Garcia";
            persona.FechaNacimiento = new DateTime(2004, 11, 24);


            return View(persona);
        }
    }
}