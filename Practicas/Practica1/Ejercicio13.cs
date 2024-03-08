using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio13 : Practica
    {
        public Ejercicio13(Menu menu, string description) : base(menu, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("El problema de la expresión es que si b es igual a 0, se produce una excepción de división por cero. Para resolverlo, se puede utilizar el operador lógico && en lugar de & para que la segunda condición no se evalúe si la primera es falsa.");
        }
    }
}