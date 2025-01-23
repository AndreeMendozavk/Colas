using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Proyecto_Colas {
    internal class Cola 
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        private int contador = 0;

        //Metodo Encolar    
        public void Enqueue(string nom) {
            Nodo nuevo = new Nodo();
            nuevo.Nombre=nom;

            if (primero==null) {
                primero=nuevo;
                ultimo=nuevo;
            } else {
                ultimo.Siguiente=nuevo;
                ultimo=nuevo;
            }
            contador++;
        }

        public bool validarTexto(string nom) 
        {
               
           /* foreach (char n in nom) 
            {
                if (char.IsLetter(n)) 
                {
                    return true;
                } 
            }
            return false;    
            */

            if (Regex.IsMatch(nom,@"ˆ[a-zA-Z\s]+$") && !string.IsNullOrWhiteSpace(nom)) 
            {
                return true;
            }
            return false;
        
        }

        //Metodo Mostrar
        public void Mostrar(ListBox list) 
        {
            Nodo actual = primero;
            while(actual!=null) 
            {
                list.Items.Add(actual.Nombre);
                actual=actual.Siguiente;
            }
        }

        //Metodo Desencolar
        public string Dequeue() 
        {
            if(primero==null) 
            {
                return null;
            }
            string nom = primero.Nombre;
            primero=primero.Siguiente;
            contador--;

            return nom;
        }

        public int Count()      
        {
            return contador;
        }

        public void Clear() 
        {
            primero=null;
            ultimo=null;
            contador=0;
        }

        public string Peek()
        {
            if (primero==null) 
            {
                return null;
            }

            return primero.Nombre;
        }


    }
}
