using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio13(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?\n" +
        "Console.WriteLine(args == null);\n"                                                   +
        "Console.WriteLine(args.Length);";

    protected override void Execute()
    {
        Console.WriteLine("La salida por consola si no se pasan argumentos por la línea de comandos es:\n" +
                          "False\n"                                                                        +
                          "0\n");
    }
}