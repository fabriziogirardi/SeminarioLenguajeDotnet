using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio6(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Supongamos que Program.cs sólo tiene las siguientes dos líneas:\n" +
        "int i;\n"                                                          +
        "Console.WriteLine(i);\n"                                           +
        "¿Por qué no compila?";

    protected override void Execute()
    {
        Console.WriteLine("No compila porque la variable i no ha sido inicializada.");
    }
}