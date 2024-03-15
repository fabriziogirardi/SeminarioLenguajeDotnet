using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio16(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Analizar el siguiente código. ¿Cuál es la salida por consola?\r\n\r\n" +
        "int i = 1;\r\n"                                                        +
        "if (--i == 0)\r\n"                                                     +
        "{\r\n"                                                                 +
        "Console.WriteLine(\"cero\");\r\n"                                      +
        "}\r\n"                                                                 +
        "if (i++ == 0)\r\n"                                                     +
        "{\r\n"                                                                 +
        "Console.WriteLine(\"cero\");\r\n"                                      +
        "}\r\n"                                                                 +
        "Console.WriteLine(i);";

    protected override void Execute()
    {
        Console.WriteLine(
                          "La salida del código es imprimir 2 veces \"cero\", ya que el operador -- se aplica antes de la comparación haciendo que i valga 0, y el operador ++ se aplica después de la comparación por lo que i todavía vale 0 al momento de comparar. Al finalizar, el valor de i es 1");

        int i = 1;

        if (--i == 0) {
            Console.WriteLine("cero");
        }

        if (i++ == 0) {
            Console.WriteLine("cero");
        }

        Console.WriteLine(i);
    }
}