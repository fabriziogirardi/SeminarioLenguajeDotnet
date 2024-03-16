using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio11(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las\n" +
        "palabras (una por línea) de una frase ingresada por consola por el usuario.";

    protected override void Execute()
    {
        string str = Console.ReadLine() ?? "no ingreso nada";

        foreach (string s in str.Split(' ')) {
            Console.WriteLine(s);
        }
    }
}