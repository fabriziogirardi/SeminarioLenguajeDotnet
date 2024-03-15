using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio12(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Escribir un programa que imprima todos los divisores de un número entero ingresado desde la\r\n" +
        "consola. Para obtener el entero desde un string st utilizar int.Parse(st).";

    protected override void Execute()
    {
        Console.Write("Ingrese un número entero: ");
        string? input = Console.ReadLine();
        int     number;

        while (!int.TryParse(input, out number)) {
            Console.Write("El valor ingresado no es un número entero. Intente nuevamente: ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Los divisores de {number} son:");

        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                Console.WriteLine(i);
            }
        }
    }
}