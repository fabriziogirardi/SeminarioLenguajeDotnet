using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio4(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Codificar la clase Hora de tal forma que el siguiente código produzca la salida por consola que se\n" +
        "observa.\n\n"                                                                                         +
        "Hora h = new Hora(23,30,15);\n"                                                                       +
        "h.Imprimir\n\n"                                                                                       +
        "23 horas, 30 minutos y 15 segundos";

    protected override void Execute()
    {
        Hora h = new(23, 30, 15);
        h.Imprimir();
    }
}