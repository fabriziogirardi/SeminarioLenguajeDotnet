using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio15 : Practica
    {
        public Ejercicio15(Menu menu, string description) : base(menu, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("El problema del código es que se declara la variable i dos veces, una fuera del for y otra dentro. Para solucionarlo, se debe eliminar la declaración de la variable i dentro del for, y simplemente asignarle el nuevo valor.");
        }
    }
}
