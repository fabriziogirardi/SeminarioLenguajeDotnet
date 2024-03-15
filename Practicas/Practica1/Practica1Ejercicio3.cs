using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio3(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente fragmento\r\n"     +
        "de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para que el programa\r\n" +
        "siga funcionando de igual manera\n\n"                                                                      +
        "string st = @\"c:\\windows\\system\";\r\n"                                                                 +
        "Console.WriteLine(st);";

    protected override void Execute()
    {
        string st = @"c:\windows\system";
        Console.WriteLine($"Con arroba: {st}");
        st = "c:\\windows\\system";
        Console.WriteLine($"Sin arroba: {st}");
    }
}