using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio11(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y contestar\r\n" +
        "las preguntas.\r\n\r\n"                                                                               +
        "Console.WriteLine(\"10/3 = \" + 10 / 3);\r\n"                                                         +
        "Console.WriteLine(\"10.0/3 = \" + 10.0 / 3);\r\n"                                                     +
        "Console.WriteLine(\"10/3.0 = \" + 10 / 3.0);\r\n"                                                     +
        "int a = 10, b = 3;\r\n"                                                                               +
        "Console.WriteLine(\"Si a y b son variables enteras, si a=10 y b=3\");\r\n"                            +
        "Console.WriteLine(\"entonces a/b = \" + a / b);\r\n"                                                  +
        "double c = 3;\r\n"                                                                                    +
        "Console.WriteLine(\"Si c es una variable double, c=3\");\r\n"                                         +
        "Console.WriteLine(\"entonces a/c = \" + a / c);\r\n\r\n"                                              +
        "a) ¿Qué se puede concluir respecto del operador de división “/” ?\r\n"                                +
        "b) ¿Cómo funciona el operador + entre un string y un dato numérico?";

    protected override void Execute()
    {
        Console.WriteLine("10/3 = "   + 10   / 3);
        Console.WriteLine("10.0/3 = " + 10.0 / 3);
        Console.WriteLine("10/3.0 = " + 10   / 3.0);

        int a = 10, b = 3;
        Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
        Console.WriteLine("entonces a/b = " + a / b);

        double c = 3;
        Console.WriteLine("Si c es una variable double, c=3");
        Console.WriteLine("entonces a/c = " + a / c);

        Console.WriteLine(
                          "a) Cuando uno de los operandos de la división es un flotante, el resultado es un flotante, mientras que si ambos operandos son enteros, el resultado es un entero y se descarta el resto.");

        Console.WriteLine(
                          "b) El + entre un string y un entero, convierte el entero a string y concatena ambos strings.");
    }
}