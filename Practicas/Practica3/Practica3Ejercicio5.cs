using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio5(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz\n" +
        "pasada como parámetro:\n\n"                                                                         +
        "double[][] GetArregloDeArreglo(double [,] matriz)";

    protected override void Execute()
    {
        double[,]  matriz           = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9, }, };
        double[][] arregloDeArreglo = GetArregloDeArreglo(matriz);
        Console.WriteLine("Arreglo de Arreglo: ");

        foreach (double[] arreglo in arregloDeArreglo) {
            Console.WriteLine("[" + string.Join(", ", arreglo) + "]");
        }
    }

    private double[][] GetArregloDeArreglo(double[,] matriz)
    {
        double[][] arregloDeArreglo = new double[matriz.GetLength(0)][];

        for (int i = 0; i < matriz.GetLength(0); i++) {
            arregloDeArreglo[i] = new double[matriz.GetLength(1)];

            for (int j = 0; j < matriz.GetLength(1); j++) {
                arregloDeArreglo[i][j] = matriz[i, j];
            }
        }

        return arregloDeArreglo;
    }
}