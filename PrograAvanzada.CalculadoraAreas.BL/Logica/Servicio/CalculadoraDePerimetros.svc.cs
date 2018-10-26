using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CalculadoraDePerimetros : ICalculadoraPerimetro
    {
      

        public double RectanguloPerimetro(double elLado1, double elLado2)
        {
            var laEspecificacion = new Logica.Especificacion.PerimetroDeUnRectangulo();
            var elResultado = laEspecificacion.CalculePerimetroRectangulo(elLado1,elLado2);
            return elResultado;
        }
    }
}
