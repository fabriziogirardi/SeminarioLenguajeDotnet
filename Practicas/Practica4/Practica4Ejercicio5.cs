using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio5(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Agregar un segundo constructor a la clase Hora para que pueda especificarse la hora por medio de\n"       +
        "un único valor que admita decimales. Por ejemplo 3,5 indica la hora 3 y 30 minutos. Si se utiliza este\n" +
        "segundo constructor, el método imprimir debe mostrar los segundos con tres dígitos decimales. Así el\n"   +
        "siguiente código debe producir la salida por consola que se observa.\n\n"                                 +
        "new Hora(23, 30, 15).Imprimir();\n"                                                                       +
        "new Hora(14.43).Imprimir();\n"                                                                            +
        "new Hora(14.45).Imprimir();\n"                                                                            +
        "new Hora(14.45114).Imprimir();\n\n"                                                                       +
        "23 horas, 30 minutos y 15 segundos\n"                                                                     +
        "14 horas, 25 minutos y 48,000 segundos\n"                                                                 +
        "14 horas, 27 minutos y 0,000 segundos\n"                                                                  +
        "14 horas, 27 minutos y 4,104 segundos";

    protected override void Execute()
    {
        new Hora(23, 30, 15).Imprimir();
        new Hora(14.43).Imprimir();
        new Hora(14.45).Imprimir();
        new Hora(14.45114).Imprimir();
    }
}