using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio7(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Cuál es la salida por consola del siguiente fragmento de código? ¿Por qué la tercera y sexta línea\n" +
        "producen resultados diferentes?\n"                                                                     +
        "char c1 = 'A';\n"                                                                                      +
        "char c2 = 'A';\n"                                                                                      +
        "Console.WriteLine(c1 == c2);\n"                                                                        +
        "object o1 = c1;\n"                                                                                     +
        "object o2 = c2;\n"                                                                                     +
        "Console.WriteLine(o1 == o2);\n";

    protected override void Execute()
    {
        Console.WriteLine("La salida por consola del siguiente fragmento de código es:\n"                            +
                          "True\n"                                                                                   +
                          "False\n"                                                                                  +
                          "La tercera y sexta línea producen resultados diferentes porque en la tercera línea se\n"  +
                          "comparan los valores de los caracteres, mientras que en la sexta línea se comparan las\n" +
                          "referencias de los objetos que contienen a los caracteres.\n");
    }
}