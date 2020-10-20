using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_Propuestos.Models;

namespace Ejercicio_Propuestos.Controllers
{
    public class MatriculaController : Controller
    {
        // GET: Matricula
        public ActionResult Matricula(int tipo = 0, int gradoSuperior = 0, int provincia = 0, int hermano = 0)
        {
            Matricula objMatricula = new Matricula();
            switch (tipo)
            {
                case 1:
                    objMatricula.subTotal += 200;
                    if (provincia == 1)
                    {
                        objMatricula.porcentaje += 5;
                    }
                    break;
                case 2:
                    objMatricula.subTotal += 150;
                    break;
                case 3:
                    objMatricula.subTotal += 100;
                    break;
                default:
                    break;
            }

            if (gradoSuperior == 1)
            {
                objMatricula.porcentaje += 10;
            }
            else if (gradoSuperior == 2)
            {
                objMatricula.porcentaje += 15;
            }

            if (hermano > 1)
            {
                objMatricula.porcentaje = 50;
            }

            objMatricula.descuento = (objMatricula.subTotal * objMatricula.porcentaje) / 100;
            objMatricula.total = objMatricula.subTotal - objMatricula.descuento;
            return View(objMatricula);
        }


    }
}