using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio8(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:\r\n" +
        "Console.WriteLine(st=Console.ReadLine());?";

    protected override void Execute()
    {
        // Explicar lo siguiente en pantalla Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:

        string? st;

        Console.WriteLine(
                          "La instrucción Console.WriteLine(st = Console.ReadLine()); es válida, pero no imprime el valor de la variable st, sino que imprime el valor que se le asigna a st, que es el valor que se lee del teclado.");

        Console.WriteLine(st = Console.ReadLine());
    }
}