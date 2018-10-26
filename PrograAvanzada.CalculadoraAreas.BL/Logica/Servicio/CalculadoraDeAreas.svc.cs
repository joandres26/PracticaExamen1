using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograAvanzada.CalculadoraAreas.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculadoraDeAreas : ICalculadoraAreas
    {
        public double Cuadrado(double elLado)
        {
            //Logica.Especificacion.AreaDeUnCuadrado laEspecificacion = new Logica.Especificacion.AreaDeUnCuadrado();
            var laEspecificacion = new Logica.Especificacion.AreaDeUnCuadrado();
            var elResultado = laEspecificacion.Calcule(elLado);
            return elResultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double Poligono(double perimetro, double apotema)
        {
            throw new NotImplementedException();
        }

        public double Rombo(double diagonalMayor, double diagonalMenor)
        {
            throw new NotImplementedException();
        }

        public double Trapecio(double lado1, double lado2, double lado3, double lado4)
        {
            var laEspecificacion = new Logica.Especificacion.AreaDeUnCuadrado();
            var elResultado = laEspecificacion.Calcule4Lados(lado1,lado2,lado3,lado4);
            return elResultado;
        }

        public double Triangulo(double ladoUno, double ladoDos, double ladoTres)
        {
            throw new NotImplementedException();
        }
    }
}
