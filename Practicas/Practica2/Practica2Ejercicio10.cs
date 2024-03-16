using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio10(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria\n" +
        "heap cuando la ejecución alcanza los puntos indicados (comentarios en el código)\n\n"             +
        "using System.Text;\n"                                                                             +
        "object[] v = new object[10];\n"                                                                   +
        "v[0] = new StringBuilder(\"Net\");\n"                                                             +
        "for (int i = 1; i < 10; i++)\n"                                                                   +
        "{\n"                                                                                              +
        "    v[i] = v[i - 1];\n"                                                                           +
        "}\n"                                                                                              +
        "(v[5] as StringBuilder).Insert(0, \"Framework .\");\n"                                            +
        "foreach (StringBuilder s in v)\n"                                                                 +
        "    Console.WriteLine(s);\n\n"                                                                    +
        "//dibujar el estado de la pila y la mem. heap\n"                                                  +
        "//en este punto de la ejecución\n\n"                                                              +
        "v[5] = new StringBuilder(\"CSharp\");\n"                                                          +
        "foreach (StringBuilder s in v)\n"                                                                 +
        "Console.WriteLine(s);\n\n"                                                                        +
        "//dibujar el estado de la pila y la mem. heap\n"                                                  +
        "//en este punto de la ejecución\n";

    protected override void Execute()
    {
        Console.WriteLine("El programa dado crea un arreglo de 10 elementos de tipo object, y asigna el primer\n" +
                          "elemento a un nuevo objeto de tipo StringBuilder con el valor \"Net\".\n"              +
                          "Luego, en un ciclo for, asigna a cada elemento del arreglo el valor del elemento\n"    +
                          "anterior, de manera que todos los elementos del arreglo apuntan al mismo objeto\n"     +
                          "StringBuilder.\n"                                                                      +
                          "Después, inserta el texto \"Framework .\" al inicio del objeto StringBuilder en la\n"  +
                          "posición 5 del arreglo, y finalmente imprime todos los elementos del arreglo.\n"       +
                          "En este punto, el estado de la pila y la memoria heap es el siguiente:\n\n"            +
                          "Stack\t\t\t\t\tHeap\n"                                                                 +
                          "v[0] ptr a heap 01\t\t\t01 - StringBuilder(\"Framework .Net\")\n"                      +
                          "v[1] ptr a heap 01\n"                                                                  +
                          "v[2] ptr a heap 01\n"                                                                  +
                          "v[3] ptr a heap 01\n"                                                                  +
                          "v[4] ptr a heap 01\n"                                                                  +
                          "v[5] ptr a heap 01\n"                                                                  +
                          "v[6] ptr a heap 01\n"                                                                  +
                          "v[7] ptr a heap 01\n"                                                                  +
                          "v[8] ptr a heap 01\n"                                                                  +
                          "v[9] ptr a heap 01\n\n"                                                                +
                          "Después, asigna un nuevo objeto StringBuilder con el valor \"CSharp\" al elemento 5\n" +
                          "del arreglo, y finalmente imprime todos los elementos del arreglo.\n"                  +
                          "En este punto, el estado de la pila y la memoria heap es el siguiente:\n\n"            +
                          "Stack\t\t\t\t\tHeap\n"                                                                 +
                          "v[0] ptr a heap 01\t\t\t01 - StringBuilder(\"Framework .Net\")\n"                      +
                          "v[1] ptr a heap 01\t\t\t02 - StringBuilder(\"CSharp\")\n"                              +
                          "v[2] ptr a heap 01\n"                                                                  +
                          "v[3] ptr a heap 01\n"                                                                  +
                          "v[4] ptr a heap 01\n"                                                                  +
                          "v[5] ptr a heap 02\n"                                                                  +
                          "v[6] ptr a heap 01\n"                                                                  +
                          "v[7] ptr a heap 01\n"                                                                  +
                          "v[8] ptr a heap 01\n"                                                                  +
                          "v[9] ptr a heap 01\n");
    }
}