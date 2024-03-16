using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio19(Menu menu, string[] args) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Idem. al ejercicio 18.a) y 18.b) pero devolviendo el resultado en un parámetro de salida void\n" +
        "Fac(int n, out int f)";

    protected override void Execute()
    {
        if (args.Length != 1) {
            Console.WriteLine($"Error: Se esperaba un argumento, se pasaron {args.Length}");
            return;
        }

        if (!int.TryParse(args[0], out int n)) {
            Console.WriteLine($"Error: El argumento {args[0]} no es un número entero");
            return;
        }

        Factorial(n, out int f1);
        Console.WriteLine($"Factorial de {args[0]} (no recursivo): {f1}");

        FactorialRecursivo(n, out int f2);
        Console.WriteLine($"Factorial de {args[0]} (recursivo): {f2}");
    }

    private void Factorial(int n, out int f)
    {
        f = 1;

        for (int i = 1; i <= n; i++) {
            f *= i;
        }
    }

    private void FactorialRecursivo(int n, out int f)
    {
        if (n == 0) {
            f = 1;
            return;
        }

        FactorialRecursivo(n - 1, out f);
        f *= n;
    }
}