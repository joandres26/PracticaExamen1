using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Accion
{
    public class CalcularPerimetroRectangulo
    {

        public double CalcularPerimetro(double elLado1, double elLado2)
        {
            double elPerimetro = 2 * (elLado1 + elLado2);
            return elPerimetro; 

        }
    }
}