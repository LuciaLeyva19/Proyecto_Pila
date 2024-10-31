using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pila
{
    internal class pila
    {
        private int MAX;
        private int tope = 0;
        private nodo inicio;

        public pila (int max)
        {
            MAX = max;
            inicio = null;
        }
        
        public bool Empty()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public bool Full()
        {
            if (tope == MAX) 
                return true;
            else
            {
                return false;
            }
        }

        public void EstablecerTamano(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor que 0");
                return;
            }

            MAX += cantidad;
            Console.WriteLine($"Capacidad de la pila incrementada. Nuevo tope máximo: {MAX}");
 
        }

        public void PrintStack()
        {
            nodo act = inicio;

            Console.WriteLine("Elementos de la pila:");
            while (act != null)
            {
                Console.WriteLine(act.Valor);
                act = act.Sig;
            }
            //Imprime la pila
        }

        public bool Push(int num)
        {

            if (Full())
                return false;

            nodo nuevo = new nodo(num);
            nuevo.Sig = inicio;
            inicio = nuevo;
            tope++;
            return true;
            //Regresa true si la inserción es exitosa 
            //Regresa false si la pila esta llena y no se insertó
            //No muestra mensajes por dentro
        }

        public int Pop()
        {
            if (Empty())
                return -1;

            int valor = inicio.Valor;
            inicio = inicio.Sig;
            tope--;
            return valor;
            //Regresa el numero sacado de la pila
            //Si la pila esta vacia regresa -1
        }


    }
}
