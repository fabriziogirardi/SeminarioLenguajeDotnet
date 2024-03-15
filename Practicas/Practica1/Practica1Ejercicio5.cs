using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio5(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el\r\n"      +
        "nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María” debe\r\n"    +
        "imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso, debe\r\n"         +
        "imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha ingresado una línea\r\n" +
        "vacía.\r\n\r\n"                                                                                          +
        "a) utilizando if ... else if\r\n"                                                                        +
        "b) utilizando switch";

    protected override void Execute()
    {
        Console.Write("Escriba su nombre: ");
        string? str = Console.ReadLine();

        Console.WriteLine("Resultado usando IF: ");

        if (str != null && str.Length > 0) {
            if (str == "Juan") {
                Console.WriteLine("¡Hola amigo!");
            } else if (str == "María") {
                Console.WriteLine("Buen día señora");
            } else if (str == "Alberto") {
                Console.WriteLine("Hola Alberto");
            } else {
                Console.WriteLine($"Buen día {str}!");
            }
        } else {
            Console.WriteLine("¡Buen día mundo!");
        }

        Console.WriteLine();
        Console.WriteLine("Resultado usando SWITCH: ");

        switch (str) {
            case "Juan":
                Console.WriteLine("¡Hola amigo!");
                break;

            case "María":
                Console.WriteLine("Buen día señora");
                break;

            case "Alberto":
                Console.WriteLine("Hola Alberto");
                break;

            default:
                if (str != null && str.Length > 0) {
                    Console.WriteLine($"Buen día {str}!");
                } else {
                    Console.WriteLine("¡Buen día mundo!");
                }

                break;
        }
    }
}