using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio17(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Cuál es la salida por consola del siguiente programa:\n\n"               +
        "try\n"                                                                   +
        "{\n"                                                                     +
        "    Metodo1();\n"                                                        +
        "}\n"                                                                     +
        "catch\n"                                                                 +
        "{\n"                                                                     +
        "    Console.WriteLine(\"Método 1 propagó una excepción no tratada\");\n" +
        "}\n"                                                                     +
        "try\n"                                                                   +
        "{\n"                                                                     +
        "    Metodo2();\n"                                                        +
        "}\n"                                                                     +
        "catch\n"                                                                 +
        "{\n"                                                                     +
        "    Console.WriteLine(\"Método 2 propagó una excepción no tratada\");\n" +
        "}\n"                                                                     +
        "try\n"                                                                   +
        "{\n"                                                                     +
        "    Metodo3();\n"                                                        +
        "}\n"                                                                     +
        "catch\n"                                                                 +
        "{\n"                                                                     +
        "    Console.WriteLine(\"Método 3 propagó una excepción\");\n"            +
        "}\n\n"                                                                   +
        "void Metodo1()\n"                                                        +
        "{\n"                                                                     +
        "    object obj = \"hola\";\n"                                            +
        "    try\n"                                                               +
        "    {\n"                                                                 +
        "        int i = (int)obj;\n"                                             +
        "    }\n"                                                                 +
        "    finally\n"                                                           +
        "    {\n"                                                                 +
        "        Console.WriteLine(\"Bloque finally en Metodo1\");\n"             +
        "    }\n"                                                                 +
        "}\n"                                                                     +
        "void Metodo2()\n"                                                        +
        "{\n"                                                                     +
        "    object obj = \"hola\";\n"                                            +
        "    try\n"                                                               +
        "    {\n"                                                                 +
        "        int i = (int)obj;\n"                                             +
        "    }\n"                                                                 +
        "    catch (OverflowException)\n"                                         +
        "    {\n"                                                                 +
        "        Console.WriteLine(\"Overflow\");\n"                              +
        "    }\n"                                                                 +
        "}\n"                                                                     +
        "void Metodo3()\n"                                                        +
        "{\n"                                                                     +
        "    object obj = \"hola\";\n"                                            +
        "    try\n"                                                               +
        "    {\n"                                                                 +
        "        int i = (int)obj;\n"                                             +
        "    }\n"                                                                 +
        "    catch (InvalidCastException)\n"                                      +
        "    {\n"                                                                 +
        "        Console.WriteLine(\"Excepción InvalidCast en Metodo3\");\n"      +
        "        throw;\n"                                                        +
        "    }\n"                                                                 +
        "}";

    protected override void Execute()
    {
        Console.WriteLine("La salida por consola del programa es:");
        Console.WriteLine("Bloque finally en Método1");
        Console.WriteLine("Método 1 propagó una excepción no tratada");
        Console.WriteLine("Método 2 propagó una excepción no tratada");
        Console.WriteLine("Excepción InvalidCast en Método3");
        Console.WriteLine("Método 3 propagó una excepción");
    }
}