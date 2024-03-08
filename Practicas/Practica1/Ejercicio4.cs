using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio4 : Practica
    {
        public Ejercicio4(Menu parent, string description) : base(parent, description)
        {
        }
        public override void Execute()
        {
            Console.Write("Escriba su nombre: ");
            string? str = Console.ReadLine();

            if (str != null && str.Length > 0) {
                Console.WriteLine($"Hola, {str}!");
            } else {
                Console.WriteLine("Hola mundo!");
            }
        }
    }
}
