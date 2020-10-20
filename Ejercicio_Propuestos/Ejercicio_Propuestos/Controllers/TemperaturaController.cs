using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_Propuestos.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Temperatura(double grados = 0)
        {
            double F = 32 + ((9 * grados) / 5);
            ViewBag.f = F;
            return View();
        }
    }
}