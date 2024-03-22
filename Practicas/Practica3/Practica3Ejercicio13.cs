using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio13(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Utilizar la clase Stack<T> (pila) para implementar un programa\n"          +
        "que pase un número en base 10 a otra base realizando divisiones\n"         +
        "sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos\n"     +
        "sucesivamente por dos hasta encontrar un cociente menor que el\n"          +
        "divisor, luego el resultado se obtiene leyendo de abajo hacia arriba el\n" +
        "cociente de la última división seguida por todos los restos.";

    protected override void Execute()
    {
        Console.WriteLine("Introduce un número en base 10 para convertir a otra base:");
        int number = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Introduce la base a la que quieres convertir el número:");
        int toBase = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"{number} en base 10 es {ConvertToBase(number, toBase)} en base {toBase}.");
    }

    static private string ConvertToBase(int number, int toBase)
    {
        Stack<int> stack = new();

        while (number > 0) {
            stack.Push(number % toBase);
            number /= toBase;
        }

        string result = "";

        while (stack.Count > 0) {
            result += stack.Pop();
        }

        return result;
    }
}