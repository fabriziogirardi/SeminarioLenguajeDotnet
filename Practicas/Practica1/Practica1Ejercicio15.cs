using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio15(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Cuál es el problema del código siguiente y cómo se soluciona?\r\n\r\n" +
        "int i = 0;\r\n"                                                         +
        "for (int i = 1; i <= 10;)\r\n"                                          +
        "{\r\n"                                                                  +
        "Console.WriteLine(i++);\r\n"                                            +
        "}";

    protected override void Execute()
    {
        Console.WriteLine(
                          "El problema del código es que se declara la variable i dos veces, una fuera del for y otra dentro. Para solucionarlo, se debe eliminar la declaración de la variable i dentro del for, y simplemente asignarle el nuevo valor.");
    }
}