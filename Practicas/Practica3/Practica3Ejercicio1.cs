using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio1(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Ejecutar y analizar cuidadosamente el siguiente programa:\n\n"                                 +
        "Console.CursorVisible = false;\n"                                                              +
        "ConsoleKeyInfo k = Console.ReadKey(true);\n"                                                   +
        "while (k.Key != ConsoleKey.End)\n"                                                             +
        "{\n"                                                                                           +
        "    Console.Clear();\n"                                                                        +
        "    Console.Write($\"{k.Modifiers}-{k.Key}-{k.KeyChar}\");\n"                                  +
        "    k = Console.ReadKey(true);\n"                                                              +
        "}\n\n"                                                                                         +
        "Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera se\n" +
        "puede acceder a esta información en el código del programa.";

    protected override void Execute()
    {
        Console.CursorVisible = false;
        ConsoleKeyInfo k = Console.ReadKey(true);

        while (k.Key != ConsoleKey.End) {
            Console.Clear();
            Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
            k = Console.ReadKey(true);
        }
    }
}