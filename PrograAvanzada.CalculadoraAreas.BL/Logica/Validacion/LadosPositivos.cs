using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Validacion
{
    public class LadosPositivos
    {
        public bool Verificar (double elLado)
        {
            var elResultado = (elLado > 0);
            return elResultado;
        }

        public bool Verificar4Lados(double lado1, double lado2, double lado3, double lado4)
        {
            var elResultado = (lado1 > 0 && lado2>0 &&lado3>0 &&lado4>0);
            return elResultado;
        }
    }
}