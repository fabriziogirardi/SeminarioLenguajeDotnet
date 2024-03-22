using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio2(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos\n"   +
        "dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea\n" +
        "en la consola.\n\n"                                                                                    +
        "void ImprimirMatriz(double[,] matriz)\n\n"                                                             +
        "Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.";

    protected override void Execute()
    {
        double[,] matriz = {
                               { 1.1, 1.2, 1.3, 1.4, },
                               { 2.1, 2.2, 2.3, 2.4, },
                               { 3.1, 3.2, 3.3, 3.4, },
                               { 4.1, 4.2, 4.3, 4.4, },
                           };

        ImprimirMatriz(matriz);
    }

    private void ImprimirMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write($"{matriz[i, j],6}");
            }

            Console.WriteLine();
        }
    }
}