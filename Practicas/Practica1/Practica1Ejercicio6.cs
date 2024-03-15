using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio6(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Utilizar Console.ReadLine() para leer líneas de texto (secuencia de caracteres que finaliza al\r\n"       +
        "presionar <ENTER>) por la consola. Por cada línea leída se debe imprimir inmediatamente la cantidad\r\n"  +
        "de caracteres de la misma. El programa termina al ingresar la cadena vacía.\r\n"                          +
        "Tip: si st es una variable de tipo string, entonces st.Length devuelve la cantidad de caracteres del\r\n" +
        "string.";

    protected override void Execute()
    {
        Console.Write("Escriba una cadena de texto: ");
        string? str = Console.ReadLine();

        while (str != null && str.Length > 0) {
            Console.WriteLine($"La cadena tiene {str.Length} caracteres.");
            Console.Write("Escriba una cadena de texto: ");
            str = Console.ReadLine();
        }
    }
}