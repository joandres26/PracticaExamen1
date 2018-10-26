using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Especificacion
{
    public class PerimetroDeUnRectangulo
    {

        public double CalculePerimetroRectangulo(double elLado1,double elLado2)
        {
            var laValidacion = new Validacion.LadosPositivos();
            if (laValidacion.Verificar2Lados(elLado1,elLado2))
            {
                var laAccion = new Accion.CalcularPerimetroRectangulo();

                var elResultado = laAccion.CalcularPerimetro(elLado1,elLado2);
                return elResultado;
            }
            else
                throw new Exception("El valor de los lados debe ser positivo.");
        }

    }
}