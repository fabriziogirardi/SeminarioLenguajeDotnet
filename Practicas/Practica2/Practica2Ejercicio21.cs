using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio21(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Codificar el método Imprimir para que el siguiente código produzca la salida por consola que se\n"        +
        "observa. Considerar que el usuario del método Imprimir podría querer más adelante imprimir otros\n"       +
        "datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros cada vez que invoque el\n" +
        "método. Tip: usar params";

    protected override void Execute()
    {
        Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
        Imprimir(1, 2,      "tres");
        Imprimir();
        Imprimir("-------------");
    }

    private void Imprimir(params object[] args) => Console.WriteLine(string.Join(" ", args));
}