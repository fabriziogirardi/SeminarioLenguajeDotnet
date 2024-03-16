using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio20(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio\n" +
        "debe apreciarse en el método invocador.";

    protected override void Execute()
    {
        Console.WriteLine("Introduce dos números separados por un espacio: ");
        string input = Console.ReadLine() ?? "";

        string[] numbers = input.Split(' ');

        if (numbers.Length != 2) {
            Console.WriteLine("Debes introducir dos números separados por un espacio.");
            return;
        }

        if (!int.TryParse(numbers[0], out int a) || !int.TryParse(numbers[1], out int b)) {
            Console.WriteLine("Debes introducir dos números enteros.");
            return;
        }

        Console.WriteLine($"Los números introducidos son: {a} y {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"Los números intercambiados son: {a} y {b}");
    }

    private void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}