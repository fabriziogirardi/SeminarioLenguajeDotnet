using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio4(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un saludo\r\n"      +
        "personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una línea en blanco.\r\n" +
        "Para ingresar un string desde el teclado utilizar Console.ReadLine()";

    protected override void Execute()
    {
        Console.Write("Escriba su nombre: ");
        string? str = Console.ReadLine();

        if (str != null && str.Length > 0) {
            Console.WriteLine($"Hola, {str}!");
        } else {
            Console.WriteLine("Hola mundo!");
        }
    }
}