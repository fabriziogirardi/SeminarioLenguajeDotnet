using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio14 : Practica
    {
        public Ejercicio14(Menu menu, string description) : base(menu, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Ingrese el primer número entero: ");
            string input = Console.ReadLine();
            int num1;
            int num2;

            while (!int.TryParse(input, out num1)) {
                Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
                input = Console.ReadLine();
            }

            Console.Write("Ingrese el segundo número entero: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out num2)) {
                Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
                input = Console.ReadLine();
            }

            int min = num1 < num2 ? num1 : num2;

            Console.WriteLine($"El menor número entre {num1} y {num2} es {min}");
        }
    }
}
