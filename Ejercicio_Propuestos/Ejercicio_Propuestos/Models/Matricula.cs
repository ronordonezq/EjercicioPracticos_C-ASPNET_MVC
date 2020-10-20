using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_Propuestos.Models
{
    public class Matricula
    {
        public double porcentaje { get; set; } = 0.0;
        public double subTotal { get; set; } = 0.0;
        public double descuento { get; set; } = 0.0;
        public double total { get; set; } = 0.0;
    }
}