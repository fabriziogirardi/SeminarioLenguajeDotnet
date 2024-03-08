using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio12 : Practica
    {
        public Ejercicio12(Menu menu, string description) : base(menu, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Ingrese un número entero: ");
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number)) {
                Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Los divisores de {number} son:");
            for (int i = 1; i <= number; i++) {
                if (number % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
