using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio4(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven\n"               +
        "un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es\n" +
        "cuadrada generar una excepción ArgumentException.\n\n"                                              +
        "double[] GetDiagonalPrincipal(double[,] matriz)\n"                                                  +
        "double[] GetDiagonalSecundaria(double[,] matriz)";

    protected override void Execute()
    {
        double[,] matriz             = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9, }, };
        double[]  diagonalPrincipal  = GetDiagonalPrincipal(matriz);
        double[]  diagonalSecundaria = GetDiagonalSecundaria(matriz);
        Console.WriteLine("Diagonal Principal: "  + string.Join(", ", diagonalPrincipal));
        Console.WriteLine("Diagonal Secundaria: " + string.Join(", ", diagonalSecundaria));
    }

    private double[] GetDiagonalPrincipal(double[,] matriz)
    {
        if (matriz.GetLength(0) != matriz.GetLength(1)) {
            throw new ArgumentException("La matriz no es cuadrada");
        }

        double[] diagonal = new double[matriz.GetLength(0)];

        for (int i = 0; i < matriz.GetLength(0); i++) {
            diagonal[i] = matriz[i, i];
        }

        return diagonal;
    }

    private double[] GetDiagonalSecundaria(double[,] matriz)
    {
        if (matriz.GetLength(0) != matriz.GetLength(1)) {
            throw new ArgumentException("La matriz no es cuadrada");
        }

        double[] diagonal = new double[matriz.GetLength(0)];

        for (int i = 0; i < matriz.GetLength(0); i++) {
            diagonal[i] = matriz[i, matriz.GetLength(0) - i - 1];
        }

        return diagonal;
    }
}