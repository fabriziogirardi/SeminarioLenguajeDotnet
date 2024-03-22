using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio10(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos\n"          +
        "compuestos redondea o trunca cuando se formatean números reales restringiendo la cantidad de\n" +
        "decimales. Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas";

    protected override void Execute()
    {
        const float a = 3.14159f;

        Console.WriteLine("Con cadenas de formato compuesto: {0:0.0000}", a);
        Console.WriteLine($"Con cadenas interpoladas: {a:0.0000}");
    }
}