using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio1(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos\r\n"    +
        "WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de\r\n"            +
        "la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo una\r\n" +
        "pausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar.\r\n"       +
        "Tip: usar los métodos ReadKey() y Write() de la clase System.Console.";

    protected override void Execute()
    {
        Console.Write("Hola ");
        Console.ReadKey(true);
        Console.WriteLine("Mundo");
    }
}