using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio18(Menu menu, string[] args) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Escribir una función (método int Fac(int n)) que calcule el factorial de un número n pasado al\n" +
        "programa como parámetro por la línea de comando\n"                                                +
        "a) Definiendo una función no recursiva\n"                                                         +
        "b) Definiendo una función recursiva\n"                                                            +
        "c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional ternario)";

    protected override void Execute()
    {
        if (args.Length != 1) {
            Console.WriteLine($"Error: Se esperaba un argumento, se pasaron {args.Length}");
            return;
        }

        if (!int.TryParse(args[0], out int n)) {
            Console.WriteLine($"Error: El argumento {args[0]} no es un número entero");
        }

        Console.WriteLine($"Factorial de {n} (no recursivo): {Factorial(n)}");
        Console.WriteLine($"Factorial de {n} (recursivo): {FactorialRecursivo(n)}");
        Console.WriteLine($"Factorial de {n} (recursivo, expression-bodied): {FactorialRecursivoExpression(n)}");
    }

    private long Factorial(int n)
    {
        long result = 1;

        for (int i = 1; i <= n; i++) {
            result *= i;
        }

        return result;
    }

    private long FactorialRecursivo(int n)
    {
        if (n == 0) {
            return 1;
        }

        return n * FactorialRecursivo(n - 1);
    }

    private long FactorialRecursivoExpression(int n) => n == 0 ? 1 : n * FactorialRecursivoExpression(n - 1);
}