using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas
{
    internal abstract class Practica
    {
        public Menu parent { get; private set; }
        protected readonly string description;

        public abstract void Execute();
        
        public Practica(Menu parent, string description)
        {
            this.parent = parent;
            this.description = description;
        }

        public void Run()
        {
            ShowText();
            Execute();
            Return();
        }

        public void ShowText()
        {
            Console.Clear();
            Console.WriteLine("Consigna:");
            Console.WriteLine(description);
            Console.WriteLine();
            Console.WriteLine("Resolución:");
            Console.WriteLine();
        }

        public void Return()
        {
            Console.WriteLine();
            Console.WriteLine("Ejericio completado.");
            Console.WriteLine("Presione cualquier tecla para volver a la lista anterior.");
            Console.ReadKey(true);
            parent.Run();
        }
    }
}
