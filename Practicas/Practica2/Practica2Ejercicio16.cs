using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio16(Menu menu, string[] args) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e\n" +
        "imprima por consola un saludo personalizado para cada uno de ellos.\n"                            +
        "a) Utilizando la sentencia for\n"                                                                 +
        "b) Utilizando la sentencia foreach";

    protected override void Execute()
    {
        Console.WriteLine("Saludo personalizado para cada uno de los nombres utilizando la sentencia for:");

        for (int i = 0; i < args.Length; i++) {
            Console.WriteLine($"¡Hola {args[i]}!");
        }

        Console.WriteLine();
        Console.WriteLine("Saludo personalizado para cada uno de los nombres utilizando la sentencia foreach:");

        foreach (string nombre in args) {
            Console.WriteLine($"¡Hola {nombre}!");
        }
    }
}