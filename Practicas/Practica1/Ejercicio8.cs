using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio8 : Practica
    {
        public Ejercicio8(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            // Explicar lo siguiente en pantalla Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:

            string? st;
            Console.WriteLine("La instrucción Console.WriteLine(st = Console.ReadLine()); es válida, pero no imprime el valor de la variable st, sino que imprime el valor que se le asigna a st, que es el valor que se lee del teclado.");
            Console.WriteLine(st = Console.ReadLine());
        }
    }
}
