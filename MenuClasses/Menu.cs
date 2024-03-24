namespace SeminarioLenguajeDotnet.MenuClasses;

internal class Menu(string title, IReadOnlyList<MenuItem> items, Menu? parent = null)
{
    readonly private string _separator = " " + new string('#', Console.WindowWidth - 2);
    private          int    _lastLeft;
    private          int    _lastTop;
    private          int    _left;
    private          int    _top;

    private void Print()
    {
        const string selector = " #  Ingrese el número de opción deseada y presione ENTER: ";
        Console.WriteLine(selector);

        _top  = Console.CursorTop     - 1;
        _left = selector.IndexOf(':') + 2;

        Console.WriteLine(" #");

        for (int index = 0; index < items.Count; index++) {
            Console.Write(" #    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{index + 1}");
            Console.ResetColor();
            Console.WriteLine($".- {items[index].Name}");
            Console.ResetColor();
        }

        Console.WriteLine(" #");
        Console.Write(" #    ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("0");
        Console.ResetColor();
        Console.WriteLine($".- {(parent == null ? "Salir" : "Volver atrás")}");
    }

    private void FullPrint()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(_separator);
        Console.WriteLine(" #");
        Console.WriteLine(" #  " + title);
        Console.WriteLine(" #");
        Print();
        Console.WriteLine(" #");
        Console.WriteLine(_separator);

        _lastLeft = Console.CursorLeft;
        _lastTop  = Console.CursorTop - 1;

        Console.SetCursorPosition(_left, _top);
    }

    private void FullPrint(string? error)
    {
        if (string.IsNullOrEmpty(error)) {
            throw new ArgumentException("Value cannot be null or empty.", nameof(error));
        }

        FullPrint();
        Console.SetCursorPosition(_lastLeft, _lastTop - 1);
        Console.Write(" #  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error);
        Console.ResetColor();
        Console.SetCursorPosition(_left, _top);
    }

    private void PrintExit()
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(_separator);
        Console.WriteLine(" #");
        Console.WriteLine(" #  Gracias por usar la aplicación! Presione cualquier tecla para finalizar");
        Console.WriteLine(" #");
        Console.WriteLine(_separator);
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
            }

            parent.Run();
        } else {
            Action action = items[opcion - 1].Action;
            action();
        }
    }

    private byte SeleccionDelUsuario()
    {
        byte    seleccion;
        string? str;

        bool success = ParsearSeleccion();

        while (!success || seleccion > items.Count) {
            FullPrint($"La opción {str} no es válida, intente nuevamente");
            success = ParsearSeleccion();
        }

        return seleccion;

        bool ParsearSeleccion()
        {
            str = Console.ReadLine();
            return byte.TryParse(str, out seleccion);
        }
    }
}