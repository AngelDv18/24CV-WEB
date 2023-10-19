﻿using _24CV_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24CV_WEB.Controllers
{
    public class ValidacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarInformacion(Curriculum model)
        {

            string mensaje = "";
            if (ModelState.IsValid)
                {
                mensaje = "Datos Correctos";
                TempData["msj"] = mensaje;
                return RedirectToAction("Index");

            }
            else 
            {
                mensaje = "Datos Incorrectos";
                TempData["msj"] = mensaje;
                return View("Index", model);
            }
           
        }
    }
}
