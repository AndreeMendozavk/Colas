using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_Proyecto_5_Pila
{
    internal class PilaString
    {
        NodoString cima, nuevo, ptr;

        //Metodo Constructor
        public PilaString()
        {
            cima = null;

        }
        public bool EsVacio()
        {
            return cima == null;
        }

        //Metodo Apilar o Push 
        public  void Push(char dato)
        {
            nuevo = new NodoString();
            nuevo.info = dato;
            nuevo.sig = cima;
            cima = nuevo;
        }
        
        //Metodo Desapilar o Pop  
        public char Pop()
        {
            if (EsVacio())
            {
                Console.WriteLine("\n*** ERROR, PILA VACIA ***");
                return ' ';
            }
            else
            {
                char dato = cima.info;
                cima = cima.sig;
                return dato;
            }
        }







    }
}
