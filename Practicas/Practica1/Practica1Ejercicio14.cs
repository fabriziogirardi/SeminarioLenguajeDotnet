using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio14(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el\r\n" +
        "menor valor de otras dos variables enteras.";

    protected override void Execute()
    {
        Console.Write("Ingrese el primer número entero: ");
        string? input = Console.ReadLine();
        int     num1;
        int     num2;

        while (!int.TryParse(input, out num1)) {
            Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
            input = Console.ReadLine();
        }

        Console.Write("Ingrese el segundo número entero: ");
        input = Console.ReadLine();

        while (!int.TryParse(input, out num2)) {
            Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
            input = Console.ReadLine();
        }

        int min = num1 < num2 ? num1 : num2;

        Console.WriteLine($"El menor número entre {num1} y {num2} es {min}");
    }
}