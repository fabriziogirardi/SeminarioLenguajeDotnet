using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio1 : Practica
    {
        public Ejercicio1(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Hola ");
            Console.ReadKey(true);
            Console.WriteLine("Mundo");
        }
    }
}
