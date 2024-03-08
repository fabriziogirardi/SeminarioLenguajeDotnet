using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio16 : Practica
    {
        public Ejercicio16(Menu menu, string description) : base(menu, description)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("La salida del código es imprimir 2 veces \"cero\", ya que el operador -- se aplica antes de la comparación haciendo que i valga 0, y el operador ++ se aplica después de la comparación por lo que i todavía vale 0 al momento de comparar. Al finalizar, el valor de i es 1");

            int i = 1;
            if (--i == 0) {
                Console.WriteLine("cero");
            }
            if (i++ == 0) {
                Console.WriteLine("cero");
            }
            Console.WriteLine(i);
        }
    }
}
