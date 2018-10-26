using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograAvanzada.CalculadoraAreas.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculadoraAreas
    {
        [OperationContract]
        double Cuadrado(double elLargo);

        [OperationContract]
        double Rombo(double diagonalMayor, double diagonalMenor);

        [OperationContract]
        double Triangulo(double ladoUno, double ladoDos, double ladoTres);

        [OperationContract]
        double Poligono(double perimetro, double apotema);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        double Trapecio(double lado1, double lado2, double lado3, double lado4);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
