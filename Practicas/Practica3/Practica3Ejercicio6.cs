using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio6(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices\n"           +
        "pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño,\n"  +
        "en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de columnas de A debe\n" +
        "ser igual a la cantidad de filas de B, en caso contrario generar una excepción ArgumentException.\n\n"    +
        "double[,]? Suma(double[,] A, double[,] B)\n"                                                              +
        "double[,]? Resta(double[,] A, double[,] B)\n"                                                             +
        "double[,] Multiplicacion(double[,] A, double[,] B)";

    protected override void Execute()
    {
        double[,] a = { { 1, 2, }, { 3, 4, }, };
        double[,] b = { { 5, 6, }, { 7, 8, }, };

        double[,]? suma           = Suma(a, b);
        double[,]? resta          = Resta(a, b);
        double[,]  multiplicacion = Multiplicacion(a, b);

        Console.WriteLine("Suma: ");
        PrintMatrix(suma);
        Console.WriteLine("Resta: ");
        PrintMatrix(resta);
        Console.WriteLine("Multiplicación: ");
        PrintMatrix(multiplicacion);
    }

    private double[,]? Suma(double[,] a, double[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1)) {
            return null;
        }

        double[,] suma = new double[a.GetLength(0), a.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++) {
            for (int j = 0; j < a.GetLength(1); j++) {
                suma[i, j] = a[i, j] + b[i, j];
            }
        }

        return suma;
    }

    private double[,]? Resta(double[,] a, double[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1)) {
            return null;
        }

        double[,] resta = new double[a.GetLength(0), a.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++) {
            for (int j = 0; j < a.GetLength(1); j++) {
                resta[i, j] = a[i, j] - b[i, j];
            }
        }

        return resta;
    }

    private double[,] Multiplicacion(double[,] a, double[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0)) {
            throw new ArgumentException("La cantidad de columnas de A debe ser igual a la cantidad de filas de B");
        }

        double[,] multiplicacion = new double[a.GetLength(0), b.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++) {
            for (int j = 0; j < b.GetLength(1); j++) {
                for (int k = 0; k < a.GetLength(1); k++) {
                    multiplicacion[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return multiplicacion;
    }

    private void PrintMatrix(double[,]? matrix)
    {
        if (matrix is null) {
            Console.WriteLine("null");
            return;
        }

        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}