using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio10(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Escribir un programa que imprima en la consola todos los múltiplos de 17 o de 29 comprendidos\r\n" +
        "entre 1 y 1000.";

    protected override void Execute()
    {
        int num1 = 17;
        int num2 = 29;

        while (num1 <= 1000 || num2 <= 1000) {
            if (num1 < num2) {
                Console.WriteLine($"{num1} es múltiplo de 17");
                num1 += 17;
            } else if (num1 > num2) {
                Console.WriteLine($"{num2} es múltiplo de 29");
                num2 += 29;
            } else {
                Console.WriteLine($"{num1} es múltiplo de 17 y tambien de 29");
                num1 += 17;
                num2 += 29;
            }
        }
    }
}