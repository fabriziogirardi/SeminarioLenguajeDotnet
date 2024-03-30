using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio8(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Prestar atención a los siguientes programas (ninguno funciona correctamente):\n\n"                 +
        "Foo f = new Foo();\n"                                                                              +
        "f.Imprimir();\n\n"                                                                                 +
        "class Foo\n"                                                                                       +
        "{\n"                                                                                               +
        "    string? _bar;\n"                                                                               +
        "    public void Imprimir()\n"                                                                      +
        "    {\n"                                                                                           +
        "        Console.WriteLine(_bar.Length);\n"                                                         +
        "    }\n"                                                                                           +
        "}\n\n"                                                                                             +
        ""                                                                                                  +
        "Foo f = new Foo();\n"                                                                              +
        "f.Imprimir();\n"                                                                                   +
        "class Foo\n"                                                                                       +
        "{\n"                                                                                               +
        "    public void Imprimir()\n"                                                                      +
        "    {\n"                                                                                           +
        "        string? bar;\n"                                                                            +
        "        Console.WriteLine(bar.Length);\n"                                                          +
        "}\n"                                                                                               +
        "}\n\n"                                                                                             +
        "¿Qué se puede decir acerca de la inicialización de los objetos? ¿En qué casos son inicializados\n" +
        "automáticamente y con qué valor?";

    protected override void Execute()
    {
        Console.WriteLine("En ambos casos, la variable _bar y bar no son inicializadas. La diferencia es que "     +
                          "_bar es una variable de instancia y bar es una variable local. Las variables de "       +
                          "instancia son inicializadas automáticamente con el valor por defecto de su tipo, "      +
                          "en este caso null. Las variables locales no son inicializadas automáticamente y "       +
                          "deben ser inicializadas explícitamente antes de ser utilizadas. En el primer caso, "    +
                          "la variable _bar es inicializada automáticamente con null, por lo que el programa "     +
                          "compila correctamente pero arroja una excepción en tiempo de ejecución. En el segundo " +
                          "caso, la variable bar no es inicializada y el programa no compila.");
    }
}