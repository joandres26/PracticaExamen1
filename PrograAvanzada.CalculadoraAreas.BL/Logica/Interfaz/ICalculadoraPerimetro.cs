﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrograAvanzada.CalculadoraAreas.BL.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalculadoraPerimetro
    {
        [OperationContract]
        double RectanguloPerimetro(double elLargo1,double elLargo2);
    }
}
