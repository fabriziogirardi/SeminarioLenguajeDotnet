using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio9(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?\n\n" +
        "class A\n"                                                                       +
        "{\n"                                                                             +
        "    public void Metodo(short n) {\n"                                             +
        "        Console.Write(\"short {0} - \", n);\n"                                   +
        "    }\n\n"                                                                       +
        "    public void Metodo(int n) {\n"                                               +
        "        Console.Write(\"int {0} - \", n);\n"                                     +
        "    }\n\n"                                                                       +
        "    public int Metodo(int n) {\n"                                                +
        "        return n + 10;\n"                                                        +
        "    }\n"                                                                         +
        "}";

    protected override void Execute()
    {
        Console.WriteLine("Con respecto a la sobrecarga de métodos, se puede decir que no es posible sobrecargar " +
                          "métodos únicamente por el tipo de retorno. En el ejemplo presentado, el método "        +
                          "public int Metodo(int n) es una sobrecarga del método public void Metodo(int n) "       +
                          "pero no es posible tener dos métodos con la misma firma y distinto tipo de retorno. "   +
                          "Por lo tanto, el código no compila.");
    }
}