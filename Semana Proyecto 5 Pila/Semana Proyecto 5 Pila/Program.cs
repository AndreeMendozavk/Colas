using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Proyecto_5_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila miPila = new Pila();
            int dato;
                        
            miPila.Apilar(10); miPila.Apilar(50);
            miPila.Apilar(20); miPila.Apilar(40);
            miPila.Apilar(30); miPila.Apilar(30);
            miPila.Apilar(40); miPila.Apilar(20);
            miPila.Apilar(50); miPila.Apilar(10);
            Console.WriteLine("\n--- RECORRIDO DE LA PILA ---");
            /*miPila.Recorrido();
            miPila.Reemplazar(10, 80);
            Console.WriteLine("\n--- RECORRIDO DE LA PILA ---");
            miPila.Recorrido();
            miPila.Desapilar();
            Console.WriteLine("\n--- RECORRIDO DE LA PILA ---");
            miPila.Recorrido();
            miPila.Buscar(10);
            miPila.Buscar(25);
            miPila.Reemplazar(10, 80);*/
            Console.WriteLine("\n--- RECORRIDO DE LA PILA ---");
            miPila.Recorrido();


            //El buscar elemnto
            do
            {
                Console.Write("\nDATO A BUSCAR (0 - PARA TERMINAR):");
                dato = int.Parse(Console.ReadLine());
                miPila.Buscar(dato);
            } while (dato != 0);

            // Suprimir elemento
            do
            {
                Console.Write("\nDATO A ELIMINAR (0 - PARA TERMINAR):");
                dato = int.Parse(Console.ReadLine());
                miPila.Eliminar(dato);
               Console.WriteLine("El elemento {0} está eliminado de la pila.", dato);
                
                miPila.Recorrido();
            } while (dato != 0);

            //Suprimir elemento recurrente
            do
            {
                Console.WriteLine();
                Console.Write("\nDATO A ELIMINAR RECURRENTE (0 - PARA TERMINAR):");
                dato = int.Parse(Console.ReadLine());
                miPila.EliminarRecurrente(dato);
                Console.WriteLine("El elemento {0} está eliminado de la pila.", dato);
                miPila.Recorrido();
            } while (dato != 0);

            //Suprimir Reemplazar 
            do
            {
                Console.Write("\nDATO A REEMPLAZAR (0 - PARA TERMINAR):");
                miPila.Recorrido();
                Console.Write("\nIngrese el dato a reemplazar:");
                dato = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el dato nuevo:");
                int nuevo = int.Parse(Console.ReadLine());
                miPila.Reemplazar(dato,nuevo);

                miPila.Recorrido();
            } while (dato != 0);
        

            Console.ReadLine();
        }
    }
}
