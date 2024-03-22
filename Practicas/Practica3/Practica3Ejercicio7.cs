using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio7(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿De qué tipo quedan definidas las variables x, y, z en el siguiente código?\n\n" +
        "int i = 10;\n"                                                                   +
        "var x = i * 1.0;\n"                                                              +
        "var y = 1f;\n"                                                                   +
        "var z = i * y;";

    protected override void Execute()
    {
        Console.WriteLine("Las variables x, y, z quedan definidas como double, float y float respectivamente.");
    }
}