using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pila stack = null;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("MENU Pilas");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("2.- Push");
                Console.WriteLine("3.- Pop");
                Console.WriteLine("4.- Imprimir");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("---------------------");
                Console.Write("Seleccionar Opción => ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el tamaño de la pila: ");
                        int max = int.Parse(Console.ReadLine());
                        if (stack == null)
                        {
                            stack = new pila(max);
                            Console.WriteLine("Tamaño de la pila establecido.");
                        }
                        else
                        {
                            stack.EstablecerTamano(max);
                        }
                        break;

                    case 2:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                        }
                        else
                        {
                            Console.Write("Ingrese el número a insertar: ");
                            int num = int.Parse(Console.ReadLine());
                            if (stack.Push(num))
                                Console.WriteLine("Elemento insertado correctamente.");
                            else
                                Console.WriteLine("La pila está llena. No se pudo insertar.");
                        }
                        break;

                    case 3:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                        }
                        else
                        {
                            int popValue = stack.Pop();
                            if (popValue == -1)
                                Console.WriteLine("La pila está vacía.");
                            else
                                Console.WriteLine($"Elemento extraído: {popValue}");
                        }
                        break;

                    case 4:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                        }
                        else
                        {
                            stack.PrintStack();
                        }
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}

