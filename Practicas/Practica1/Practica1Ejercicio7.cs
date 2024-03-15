using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio7(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Qué hace la instrucción Console.WriteLine(\"100\".Length);";

    protected override void Execute()
    {
        Console.WriteLine(
                          "La instrucción Console.WriteLine(\"100\".Length) imprime en pantalla la cantidad \n" +
                          "de caracteres que tiene el string \"100\", que son 3.");

        Console.WriteLine("100".Length);
    }
}