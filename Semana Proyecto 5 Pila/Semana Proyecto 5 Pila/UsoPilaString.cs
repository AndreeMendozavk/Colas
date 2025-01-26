using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Proyecto_5_Pila
{
    internal class UsoPilaString
    {
        static void Main()
        {
            String texto;

            PilaString miPila = new PilaString();
            Console.Write("INGRESE UN TEXTO:");
            texto = Console.ReadLine();
            // Almacenar cada elemento del texto en una pila
            for (int i = 0; i < texto.Length; i++) miPila.Push(texto[i]);

            // Recuperar los elementos de la pila
            Console.WriteLine("\n*** ELEMENTOS DE LA PILA ***");
            for (int i = 0; i < texto.Length; i++) Console.Write("{0}", miPila.Pop());

            Console.ReadLine();





        }


    }
}
