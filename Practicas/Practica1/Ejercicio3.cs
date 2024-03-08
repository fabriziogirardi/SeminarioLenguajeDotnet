using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio3 : Practica
    {
        public Ejercicio3(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            string st = @"c:\windows\system";
            Console.WriteLine($"Con arroba: {st}");
            st = "c:\\windows\\system";
            Console.WriteLine($"Sin arroba: {st}");
        }
    }
}
