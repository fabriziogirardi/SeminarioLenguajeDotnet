using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio4(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Resolver los errores de compilación en el siguiente fragmento de código. Utilizar el operador as\ncuando sea posible.\n" +
        "object o = \"Hola Mundo!\";\n" +
        "string st = o;\n" +
        "int i = 12;\n" +
        "byte b = i;\n" +
        "double d = i;\n" +
        "float f = d;\n" +
        "o = i;\n" +
        "i = o + 1;";

    protected override void Execute()
    {
        Console.WriteLine("La forma correcta sería:\n"                         +
                          "object o = \"Hola Mundo!\";\n"                      +
                          "string st = (string)o; // Necesita unboxing\n"      +
                          "int i = 12;\n"                                      +
                          "byte b = (byte)i; // Necesita casteo explícito\n"   +
                          "double d = i;\n"                                    +
                          "float f = (float)d; // Necesita casteo explícito\n" +
                          "o = i;\n"                                           +
                          "i = (int)o + 1; // Necesita casteo explícito\n\n"   +
                          "Ninguno de los elementos aplica para el operador "  +
                          "\"as\" ya que no hay tipos de datos nullables");
    }
}