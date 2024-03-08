using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio5 : Practica
    {
        public Ejercicio5(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Escriba su nombre: ");
            string? str = Console.ReadLine();

            Console.WriteLine("Resultado usando IF: ");
            if (str != null && str.Length > 0) {
                if (str == "Juan") {
                    Console.WriteLine("¡Hola amigo!");
                } else if (str == "María") {
                    Console.WriteLine("Buen día señora");
                } else if (str == "Alberto") {
                    Console.WriteLine("Hola Alberto");
                } else {
                    Console.WriteLine($"Buen día {str}!");
                }
            } else {
                Console.WriteLine("¡Buen día mundo!");
            }

            Console.WriteLine();
            Console.WriteLine("Resultado usando SWITCH: ");

            switch (str) {
                case "Juan":
                    Console.WriteLine("¡Hola amigo!");
                    break;
                case "María":
                    Console.WriteLine("Buen día señora");
                    break;
                case "Alberto":
                    Console.WriteLine("Hola Alberto");
                    break;
                default:
                    if (str != null && str.Length > 0) {
                        Console.WriteLine($"Buen día {str}!");
                    } else {
                        Console.WriteLine("¡Buen día mundo!");
                    }
                    break;
            }
        }
    }
}
