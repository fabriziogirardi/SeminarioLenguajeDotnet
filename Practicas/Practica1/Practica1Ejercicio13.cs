using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio13(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente\r\n" +
        "expresión. Tip: observar qué pasa cuando b = 0.\r\n"                                                    +
        "if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);";

    protected override void Execute()
    {
        Console.WriteLine(
                          "El problema de la expresión es que si b es igual a 0, se produce una excepción de división por cero. Para resolverlo, se puede utilizar el operador lógico && en lugar de & para que la segunda condición no se evalúe si la primera es falsa.");
    }
}