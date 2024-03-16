using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio15(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando\n" +
        "se invoca desde la línea de comandos.\n"                                                            +
        "Console.WriteLine(\"¡Hola {0}!\", args[0]);";

    protected override void Execute()
    {
        Console.WriteLine("El programa imprime un saludo con el texto que se le pase como primer argumento.\n" +
                          "Si no se pasan parámetros, se lanza una excepción de tipo System.IndexOutOfRangeException.");
    }
}