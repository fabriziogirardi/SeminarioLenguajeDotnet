using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio6(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Codificar una clase llamada Ecuacion2 para representar una ecuación de 2o grado. Esta clase debe tener 3\n" +
        "campos privados, los coeficientes a, b y c de tipo double. La única forma de establecer los valores de estos\n" +
        "campos será en el momento de la instanciación de un objeto Ecuacion2.\n" +
        "Codificar los siguientes métodos:\n" +
        "\u25cf GetDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la\n" +
        "siguiente formula, (b^2)-4*a*c.\n" +
        "\u25cf GetCantidadDeRaices(): devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces reales que posee la\n" +
        "ecuación. Si el discriminante es negativo no tiene raíces reales, si el discriminante es cero tiene una\n" +
        "única raíz, si el discriminante es mayor que cero posee 2 raíces reales.\n" +
        "\u25cf ImprimirRaices(): imprime la única o las 2 posibles raíces reales de la ecuación. En caso de no\n" +
        "poseer soluciones reales debe imprimir una leyenda que así lo especifique.";

    protected override void Execute()
    {
        Ecuacion2 e = new(2, 8, 6);
        Console.WriteLine($"El discriminante es: {e.GetDiscriminante()}");
        Console.WriteLine($"La cantidad de raices es: {e.GetCantidadDeRaices()}");
        e.ImprimirRaices();
    }
}