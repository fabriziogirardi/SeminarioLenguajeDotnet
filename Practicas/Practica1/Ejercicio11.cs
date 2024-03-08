using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio11 : Practica
    {
        public Ejercicio11(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("10/3 = " + 10 / 3);
            Console.WriteLine("10.0/3 = " + 10.0 / 3);
            Console.WriteLine("10/3.0 = " + 10 / 3.0);

            int a = 10, b = 3;
            Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
            Console.WriteLine("entonces a/b = " + a / b);

            double c = 3;
            Console.WriteLine("Si c es una variable double, c=3");
            Console.WriteLine("entonces a/c = " + a / c);

            Console.WriteLine("a) Cuando uno de los operandos de la división es un flotante, el resultado es un flotante, mientras que si ambos operandos son enteros, el resultado es un entero y se descarta el resto.");
            Console.WriteLine("b) El + entre un string y un entero, convierte el entero a string y concatena ambos strings.");
        }
    }
}
