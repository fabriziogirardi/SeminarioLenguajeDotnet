using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio2(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Investigar por las secuencias de escape \\n, \\t , \\\" y \\\\. Escribir un programa que las utilice para\r\n" +
        "imprimir distintos mensajes en la consola.";

    protected override void Execute()
    {
        Console.WriteLine("- Usando \\n: Esto es \n un ejemplo.");
        Console.WriteLine("- Usando \\t: Esto es \t un ejemplo.");
        Console.WriteLine("- Usando \\\": Esto es \" un ejemplo.");
        Console.WriteLine("- Usando \\: Esto es \\ un ejemplo.");
    }
}