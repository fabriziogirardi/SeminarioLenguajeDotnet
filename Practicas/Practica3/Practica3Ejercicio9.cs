using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio9(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "¿Qué líneas del siguiente método provocan error de compilación y por qué?\n\n" +
        "var a = 3L;\n"                                                                 +
        "dynamic b = 32;\n"                                                             +
        "object obj = 3;\n"                                                             +
        "a = a * 2.0;\n"                                                                +
        "b = b * 2.0;\n"                                                                +
        "b = \"hola\";\n"                                                               +
        "obj = b;\n"                                                                    +
        "b = b + 11;\n"                                                                 +
        "obj = obj + 11;\n"                                                             +
        "var c = new { Nombre = \"Juan\" };\n"                                          +
        "var d = new { Nombre = \"María\" };\n"                                         +
        "var e = new { Nombre = \"Maria\", Edad = 20 };\n"                              +
        "var f = new { Edad = 20, Nombre = \"Maria\" };\n"                              +
        "f.Edad = 22;\n"                                                                +
        "d = c;\n"                                                                      +
        "e = d;\n"                                                                      +
        "f = e;";

    protected override void Execute()
    {
        Console.WriteLine("Las líneas que provocan error de compilación son:\n"                                    +
                          "a = a * 2.0; // \"a\" es un long y la multiplicación lo convertiría en float\n"         +
                          "obj = obj + 11; // obj necesita ser casteado como int para poder efectuarle una suma\n" +
                          "f.Edad = 22; // las propiedades de los objetos anónimos son de solo lectura\n"          +
                          "e = d; // No coinciden las propiedades de los objetos\n"                                +
                          "f = e; // No coinciden las propiedades de los objetos\n\n");
    }
}