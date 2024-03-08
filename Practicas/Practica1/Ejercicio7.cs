using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio7 : Practica
    {
        public Ejercicio7(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("La instrucción Console.WriteLine(\"100\".Length) imprime en pantalla la cantidad de caracteres que tiene el string \"100\", que son 3.");
            Console.WriteLine("100".Length);
        }
    }  
}
