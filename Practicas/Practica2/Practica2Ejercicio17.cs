using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio17(Menu menu, string[] args) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar un programa que muestre todos los números primos entre 1 y un número natural dado\n"      +
        "(pasado al programa como argumento por la línea de comandos). Definir el método bool\n"               +
        "EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es\n"           +
        "divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d) devuelve la\n" +
        "raíz cuadrada de d)";

    protected override void Execute()
    {
        if (args.Length != 1) {
            Console.WriteLine("El programa debe recibir un único argumento.");
            return;
        }

        if (!int.TryParse(args[0], out int n)) {
            Console.WriteLine("El argumento debe ser un número entero.");
            return;
        }

        Console.WriteLine($"Los números primos entre 1 y {n} son:");

        for (int i = 1; i <= n; i++) {
            if (EsPrimo(i)) {
                Console.WriteLine(i);
            }
        }
    }

    private bool EsPrimo(int n)
    {
        if (n <= 1) {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }

        return true;
    }
}