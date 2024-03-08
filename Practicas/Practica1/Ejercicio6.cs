using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio6 : Practica
    {
        public Ejercicio6(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Escriba una cadena de texto: ");
            string? str = Console.ReadLine();
            while (str != null && str.Length > 0) {
                Console.WriteLine($"La cadena tiene {str.Length} caracteres.");
                Console.Write("Escriba una cadena de texto: ");
                str = Console.ReadLine();
            }
        }
    }
}
