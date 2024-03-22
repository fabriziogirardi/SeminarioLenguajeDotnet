using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio8(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Señalar errores de compilación y/o ejecución en el siguiente código\n\n" +
        "object obj = new int[10];\n"                                             +
        "dynamic dyna = 13;\n"                                                    +
        "Console.WriteLine(obj.Length);\n"                                        +
        "Console.WriteLine(dyna.Length);";

    protected override void Execute()
    {
        Console.WriteLine("El error de compilación es que el objeto obj es de tipo object, "                  +
                          "por lo que no tiene la propiedad Length.\n"                                        +
                          "El objeto dyna es de tipo dynamic no genera error de compilación pero al recibir " +
                          "un entero como valor, e intentar acceder a la propiedad Lenght, dará un error en " +
                          "tiempo de ejecución.");
    }
}