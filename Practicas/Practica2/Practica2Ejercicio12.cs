using SeminarioLenguajeDotnet.MenuClasses;
using SeminarioLenguajeDotnet.Practicas.Practica2.Enums;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio12(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:\n"                                 +
        "a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,\n"             +
        "noviembre, octubre …, enero)\n"                                                                          +
        "b) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al nombre de\n" +
        "un mes\n"                                                                                                +
        "Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses";

    protected override void Execute()
    {
        Console.WriteLine("Item a:");

        for (Meses i = Meses.Diciembre; i >= Meses.Enero; i--) {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nItem b:");

        string input = Console.ReadLine() ?? "";

        Console.WriteLine(Enum.TryParse(input, true, out Meses result)
                              ? "El texto ingresado corresponde a un mes"
                              : "El texto ingresado no corresponde a un mes");
    }
}