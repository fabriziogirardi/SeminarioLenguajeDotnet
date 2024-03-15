using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio1(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Sea el siguiente código:\n"                                                                               +
        "object o1 = \"A\";\n"                                                                                     +
        "object o2 = o1;\n"                                                                                        +
        "o2 = \"Z\";"                                                                                              +
        "\nConsole.WriteLine(o1 + \" \" + o2);"                                                                    +
        "El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están\n" +
        "apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?";

    protected override void Execute()
    {
        Console.WriteLine("El motivo por el que la pantalla no muestra Z Z, es porque los strings son inmutables"  +
                          " y al cambiar el valor de la variable, se crea un nuevo string con el valor asignado,"  +
                          " y la variable ahora apunta a la nueva dirección de memoria, por lo que el valor de la" +
                          " variable original no cambia.");
    }
}