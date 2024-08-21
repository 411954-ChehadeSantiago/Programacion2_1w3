using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGuia1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Pila pila = new Pila(10);
        if (pila.EstaVacia())
        {
            Console.WriteLine("La pila está vacía.");
        }
        else
        {
            Console.WriteLine("La pila no está vacía.");
        }
        pila.Añadir(10);
        pila.Añadir(12);
        pila.Añadir(15);
        pila.Añadir(20);
        pila.Añadir(25);
        object primerElemento = pila.Primero();
        Console.WriteLine("El primer elemento de la pila es: " + primerElemento);
        object elementoExtraido = pila.Extraer();
        Console.WriteLine("Elemento extraído: " + elementoExtraido);
        object primerElemento2 = pila.Primero();
        Console.WriteLine("El primer elemento de la pila es: " + primerElemento2);
        pila.Añadir(50);
        object primerElemento3 = pila.Primero();
        Console.WriteLine("El primer elemento de la pila es: " + primerElemento3);
        if (pila.EstaVacia())
        {
            Console.WriteLine("La pila está vacía.");
        }
        else
        {
            Console.WriteLine("La pila no está vacía.");
        }

        }

    }
}
