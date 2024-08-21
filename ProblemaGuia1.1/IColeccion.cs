using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGuia1._1
{
    internal interface IColeccion
    {
        bool EstaVacia();
        object Extraer();
        object Primero();
        bool Añadir(object item);
    }
}
