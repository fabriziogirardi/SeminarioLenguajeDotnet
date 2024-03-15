using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio2(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Qué líneas del siguiente código provocan conversiones boxing y unboxing.\n" +
        "char c1 = 'A';\n"                                                           +
        "string st1 = \"A\";\n"                                                      +
        "object o1 = c1;\n"                                                          +
        "object o2 = st1;\n"                                                         +
        "char c2 = (char)o1;\n"                                                      +
        "string st2 = (string)o2;";

    protected override void Execute()
    {
        Console.WriteLine("Las lineas que presentan boxing son: \n" +
                          "object o1 = c1;\n"                       +
                          "object o2 = st1;");

        Console.WriteLine("Las lineas que presentan unboxing son: \n" +
                          "char c2 = (char)o1;\n"                     +
                          "string st2 = (string)o2;");
    }
}