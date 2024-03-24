using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio15(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Qué salida por la consola produce el siguiente código?\n\n" +
        "int x = 0;\n\n"                                              +
        "try {\n"                                                     +
        "    Console.WriteLine((1.0 / x).ToString());\n"              +
        "    Console.WriteLine(1 / x);\n"                             +
        "    Console.WriteLine(\"todo OK\");\n"                       +
        "}\n"                                                         +
        "catch (Exception e) {\n"                                     +
        "    Console.WriteLine(e.Message);\n"                         +
        "}";

    protected override void Execute()
    {
        Console.WriteLine("Primero se mostrará un infinito, ya que es posible dividir por cero un flotante " +
                          "y luego se lanzará una excepción de división por cero.");
    }
}