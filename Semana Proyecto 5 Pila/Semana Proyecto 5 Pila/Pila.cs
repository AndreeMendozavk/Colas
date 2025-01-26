using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Proyecto_5_Pila
{
    internal class Pila
    {
        Nodo cima, nuevo, ptr;

        //Metodo Constructor
        public Pila()
        {
            cima = null;
        }
        //Metodo EsVacio
        public bool EsVacio()
        {
            return cima == null;
        }
        //Metodo Apilar o Push
        public void Apilar(int dato)
        {
            nuevo = new Nodo();     // Crear nuevo nodo
            nuevo.info = dato;      // Guardar el dato en el campo info
            nuevo.sig = cima;       // Apilar el nodo en la cima
            cima = nuevo;           // Actualizar la cima
        }
        //Metodo Desapilar o Pop
        public  int Desapilar()
        {
            if (EsVacio())
            {
                Console.WriteLine("\n*** ERROR, LA PILA ESTA VACIA ***");
                return -1;
            }
            else
            {
                int dato = cima.info;   // Almacenando el valor del primer elemento
                cima = cima.sig;        // Actualizar la cima
                return dato;            // Retornar el valor recuperado de la cima
            }
        }
        //Metodo Recorrido 
        public void Recorrido()
        {
            if (EsVacio())
                Console.WriteLine("\n*** ERROR, LA PILA ESTA VACIA ***");
            else
            {
                ptr = cima;
                while (ptr != null)
                {
                    Console.Write("{0},", ptr.info);
                    ptr = ptr.sig;
                }
            }
        }

        //Metodo Buscar
        public void Buscar(int dato)
        {
            bool encontrado = false;
            ptr = cima;
            while (ptr != null)
            {
                if (ptr.info == dato) 
                {   
                    encontrado = true; 
                    break; 
                }
                ptr = ptr.sig;
            }
            Console.WriteLine("\n{0} {1} EXISTE", dato, encontrado ? "SI" : "NO");
        }

        //Metodo Reemplazar
        public void Reemplazar(int dato, int nuevo)
        {
            ptr = cima;
            while (ptr != null)
            {
                if (ptr.info == dato) 
                    ptr.info = nuevo;
                ptr = ptr.sig;
            }
        }
        //Metodo Eliminar
        public void Eliminar(int dato)
        {
            if (EsVacio())
            {
                Console.WriteLine("\n*** ERROR, PILA VACIA ***");
                return;
            }

            // Caso 1: El nodo a eliminar está en la cima
            else if (cima.info == dato)
            {
                cima = cima.sig;  // Actualiza la cima al siguiente nodo
                return;
            }

             // Caso 2: El nodo a eliminar no está en la cima
            else  
            {
                ptr = cima;
                while (ptr.sig!= null)
                {
                    if (ptr.sig.info == dato)
                    {
                        ptr.sig = ptr.sig.sig;  // Elimina el nodo apuntado por ptr.sig
                        return;
                    }
                    ptr = ptr.sig;  // Avanza al siguiente nodo
                }
            }
            Console.WriteLine("\n*** ERROR, EL DATO NO EXISTE EN LA PILA ***");

        }
        public void EliminarRecurrente(int dato)
        {
            // Continuamos eliminando el dato hasta que no queden más nodos con ese valor
            bool eliminado = true;

            while (eliminado)
            {
                eliminado = false;  // Asumimos que no eliminaremos nada al principio

                // Intentamos eliminar el dato de la cima
                Nodo ptr = cima;
                while (ptr != null)
                {
                    if (ptr.info == dato)
                    {
                        Eliminar(dato);  // Llamamos al método Eliminar
                        eliminado = true;  // Si eliminamos un nodo, cambiamos a true
                        break;  // Salimos del ciclo una vez que hemos eliminado un nodo
                    }
                    ptr = ptr.sig;
                }
            }
            Console.WriteLine("\n*** ERROR, EL DATO NO EXISTE EN LA PILA ***");

        }
    }
}
