using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio8(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué\n"              +
        "circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar un\n"    +
        "caso de ejemplo en el que el rendimiento sea claramente superior utilizando StringBuilder en lugar\n" +
        "de string y otro en el que no.";

    protected override void Execute()
    {
        Console.WriteLine("StringBuilder es preferible utilizarlo cuando se requiere concatenar muchas cadenas\n" +
                          "de texto, ya que es más eficiente que el operador + o el método string.Concat.\n"      +
                          "ya que no crea un nuevo objeto en memoria cada vez que se\n"                           +
                          "concatena una cadena, sino que modifica el objeto existente.\n"                        +
                          "Un codigo de ejemplo sobre el uso de StringBuilder es el siguiente:\n\n"               +
                          "StringBuilder sb = new StringBuilder();\n"                                             +
                          "for (int i = 0; i < 1000; i++)\n"                                                      +
                          "{\n"                                                                                   +
                          "    sb.Append(i);\n"                                                                   +
                          "}\n"                                                                                   +
                          "Console.WriteLine(sb.ToString());\n\n"                                                 +
                          "En este caso, el rendimiento es claramente superior "                                  +
                          "al utilizar StringBuilder en lugar de string.\n"                                       +
                          "Un caso en el que no es preferible utilizar StringBuilder es cuando se requiere\n"     +
                          "concatenar pocas cadenas de texto, ya que el rendimiento es menor al de string.\n"     +
                          "Un ejemplo de esto es el siguiente:\n\n"                                               +
                          "StringBuilder sb = new StringBuilder();\n"                                             +
                          "sb.Append(\"Hola\");\n"                                                                +
                          "sb.Append(\" \");\n"                                                                   +
                          "sb.Append(\"Mundo\");\n"                                                               +
                          "Console.WriteLine(sb.ToString());\n\n");
    }
}