using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_Propuestos.Models;

namespace Ejercicio_Propuestos.Controllers
{
    public class CreditoController : Controller
    {
        // GET: Credito
        public ActionResult Credito()
        {
            return View();
        }

        public ActionResult Calcular(double montoCompra = 0, int tipo = 0)
        {
            if(tipo != 0)
            {
                Credito objCredito = new Credito();
                objCredito.montoFactura = montoCompra + ((montoCompra * 10) / 100);

                switch (tipo)
                {
                    case 1:
                        objCredito.montoInteres += ((objCredito.montoFactura * 5) / 100);
                        objCredito.montoCuotaInicial += 60;
                        objCredito.montoLetraPagar += 2;
                        break;
                    case 2:
                        objCredito.montoInteres += ((objCredito.montoFactura * 10) / 100);
                        objCredito.montoCuotaInicial += 50;
                        objCredito.montoLetraPagar += 4;
                        break;
                    case 3:
                        objCredito.montoInteres += ((objCredito.montoFactura * 15) / 100);
                        objCredito.montoCuotaInicial += 35;
                        objCredito.montoLetraPagar += 6;
                        break;
                    default:
                        break;
                }
                objCredito.montoTotal += objCredito.montoFactura + objCredito.montoInteres;

                return View(objCredito);
            }
            else
            {
                return Redirect("~/Credito/Credito");
            }
        }
    }
}