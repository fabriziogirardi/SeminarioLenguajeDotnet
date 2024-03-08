using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.MenuClasses
{
    internal class Menu
    {
        private readonly string separator = " " + new string('#', 100);
        private string title;
        private List<MenuItem> items;
        private Menu? parent;
        private int left = 0;
        private int top = 0;
        private int lastLeft = 0;
        private int lastTop = 0;
        public Menu(string title, List<MenuItem> items, Menu? parent = null)
        {
            this.title = title;
            this.items = items;
            this.parent = parent;
        }
        private void Print()
        {
            string selector = " #  Ingrese el número de opción deseada y presione ENTER: ";
            Console.WriteLine(selector);

            top = Console.CursorTop - 1;
            left = selector.IndexOf(":") + 2;

            Console.WriteLine(" #");

            for (int index = 0; index < items.Count; index++) {
                Console.Write($" #    ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{index + 1}");
                Console.ResetColor();
                Console.WriteLine($".- {items[index].name}");
                Console.ResetColor();
            }

            Console.WriteLine(" #");
            Console.Write($" #    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");
            Console.ResetColor();
            Console.WriteLine($".- {(parent == null ? "Salir" : "Volver atrás")}");
        }

        private void FullPrint()
        {
            //Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(separator);
            Console.WriteLine(" #");
            Console.WriteLine(" #  " + title);
            Console.WriteLine(" #");
            Print();
            Console.WriteLine(" #");
            Console.WriteLine(separator);

            lastLeft = Console.CursorLeft;
            lastTop = Console.CursorTop - 1;

            Console.SetCursorPosition(left, top);
        }

        private void FullPrint(string? error = null)
        {
            FullPrint();
            Console.SetCursorPosition(lastLeft, lastTop - 1);
            Console.Write(" #  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
            Console.SetCursorPosition(left, top);
        }

        private void PrintExit()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(separator);
            Console.WriteLine(" #");
            Console.WriteLine($" #  Gracias por usar la aplicacion! Presione cualquier tecla para finalizar");
            Console.WriteLine(" #");
            Console.WriteLine(separator);
        }
        public void Run()
        {
            FullPrint();
            byte opcion = SeleccionDelUsuario();
            if (opcion == 0) {
                if (parent == null) {
                    PrintExit();
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    return;
                } else {
                    parent.Run();
                }
            } else {
                var action = items[(byte)opcion - 1].action;
                if (action != null)
                    action();
                else {
                    Console.WriteLine("Opción no existente, por favor intente nuevamente");
                    Console.ReadKey();
                    Run();
                }
            }
        }
        byte SeleccionDelUsuario()
        {
            byte seleccion = 0;
            string str = "";
            var parsearSeleccion = () => {
                str = Console.ReadLine();
                return byte.TryParse(str.ToString(), out seleccion);
            };
            bool success = parsearSeleccion();
            while (!success || seleccion < 0 || seleccion > items.Count) {
                FullPrint($"La opción {str} no es válida, intente nuevamente");
                success = parsearSeleccion();
            }
            return seleccion;
        }
    }
}
