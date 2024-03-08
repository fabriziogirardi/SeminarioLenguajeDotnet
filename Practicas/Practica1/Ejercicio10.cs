using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio10 : Practica
    {
        public Ejercicio10(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            int num1 = 17;
            int num2 = 29;

            while (num1 <= 1000 || num2 <= 1000) {
                if (num1 < num2) {
                    Console.WriteLine($"{num1} es múltiplo de 17");
                    num1 += 17;
                } else if (num1 > num2) {
                    Console.WriteLine($"{num2} es múltiplo de 29");
                    num2 += 29;
                } else {
                    Console.WriteLine($"{num1} es múltiplo de 17 y tambien de 29");
                    num1 += 17;
                    num2 += 29;
                }
            }
        }
    }
}
