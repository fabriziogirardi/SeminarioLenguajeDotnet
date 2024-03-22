using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio11(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Señalar errores de ejecución en el siguiente código\n\n" +
        "List<int> a = [ 1, 2, 3, 4 ];\n"                         +
        "a.Remove(5);\n"                                          +
        "a.RemoveAt(4);";

    protected override void Execute()
    {
        Console.WriteLine("Los errores de ejecución en el código son:\n"          +
                          "a.Remove(5); // El elemento 5 no existe en la lista\n" +
                          "a.RemoveAt(4); // El índice 4 no existe en la lista\n\n");
    }
}