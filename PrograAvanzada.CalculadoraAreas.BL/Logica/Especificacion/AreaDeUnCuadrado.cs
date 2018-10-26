using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Especificacion
{
    public class AreaDeUnCuadrado
    {
        public double Calcule(double elLado)
        {
            var laValidacion = new Validacion.LadosPositivos();
            if (laValidacion.Verificar(elLado))
            {
                var laAccion = new Accion.CalcularCuadrado();

                var elResultado = laAccion.CalcularElArea(elLado);
                return elResultado;
            }
            else
                throw new Exception("El valor de los lados debe ser positivo.");
        }

        public double Calcule4Lados(double lado1, double lado2, double lado3, double lado4)
        {
            var laValidacion = new Validacion.LadosPositivos();
            if (laValidacion.Verificar4Lados(lado1,lado2,lado3,lado4))
            {
                var laAccion = new Accion.CalcularCuadrado();

                var elResultado = laAccion.PerimetroTrapecio(lado1, lado2, lado3, lado4);
                return elResultado;
            }
            else
                throw new Exception("El valor de los lados debe ser positivo.");
        }
    }
}