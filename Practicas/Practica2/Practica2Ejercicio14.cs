using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio14(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Qué hace la instrucción? ¿Asigna a la variable vector el valor null?\n" +
        "int[]? vector = new int[0];";

    protected override void Execute()
    {
        Console.WriteLine("La instrucción int[]? vector = new int[0]; crea un vector de enteros de tamaño 0, " +
                          "pero no asigna null.");
    }
}