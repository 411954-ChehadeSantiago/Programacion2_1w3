using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGuia1._1
{
    internal class Pila  : IColeccion
    {
        private object[] elementos;
        private int contador;

        public Pila(int tamanio)
        {
            elementos = new object[tamanio];
            contador = 0;
        }

        public bool Añadir(object item)
        {
            if (contador == elementos.Length)
            {
                return false;
            }
            elementos[contador++] = item;
            return true;
        }

        public bool EstaVacia()
        {
            return contador == 0;
        }

        public object Extraer()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            object item = elementos[--contador];
            return item;
        }

        public object Primero()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            return elementos[contador - 1];
        }
    }
}
