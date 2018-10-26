using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Accion
{
    public class CalcularCuadrado
    {
        /// <summary>
        /// Realiza el cálculo del área de un cuadrado de lado específico.
        /// </summary>
        /// <param name="elLado">Medida del lado del cuadrado</param>
        /// <returns>El área del cuadrado</returns>
        public double CalcularElArea(double elLado)
        {
            double elArea = elLado * elLado;
            return elArea;
        }

        public double PerimetroTrapecio(double lado1, double lado2, double lado3, double lado4)
        {
            double elPerimetro = lado1 + lado2 + lado3 + lado4;
            return elPerimetro;
        }
    }
}