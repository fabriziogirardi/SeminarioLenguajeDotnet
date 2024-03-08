using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio2 : Practica
    {
        public Ejercicio2(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("- Usando \\n: Esto es \n un ejemplo.");
            Console.WriteLine("- Usando \\t: Esto es \t un ejemplo.");
            Console.WriteLine("- Usando \\\": Esto es \" un ejemplo.");
            Console.WriteLine("- Usando \\: Esto es \\ un ejemplo.");
        }
    }
}
