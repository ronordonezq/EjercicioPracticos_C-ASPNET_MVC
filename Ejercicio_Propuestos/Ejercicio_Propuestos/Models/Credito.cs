using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_Propuestos.Models
{
    public class Credito
    {

        public double montoFactura { get; set; } = 0.0;
        public double montoInteres { get; set; } = 0.0;
        public double montoTotal { get; set; } = 0.0;
        public double montoCuotaInicial { get; set; } = 0.0;
        public double montoLetraPagar { get; set; } = 0.0;

    }
}