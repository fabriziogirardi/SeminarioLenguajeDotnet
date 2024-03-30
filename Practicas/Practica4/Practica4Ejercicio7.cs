using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio7(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar la clase Matriz que se utilizará para trabajar con matrices matemáticas. Implementar los dos\n" +
        "constructores y todos los métodos que se detallan a continuación:\n"                                        +
        "public Matriz(int filas, int columnas)\n"                                                                   +
        "public Matriz(double[,] matriz)\n"                                                                          +
        "public void SetElemento(int fila, int columna, double elemento)\n"                                          +
        "public double GetElemento(int fila, int columna)\n"                                                         +
        "public void imprimir()\n"                                                                                   +
        "public void imprimir(string formatString)\n"                                                                +
        "public double[] GetFila(int fila)\n"                                                                        +
        "public double[] GetColumna(int columna)\n"                                                                  +
        "public double[] GetDiagonalPrincipal()\n"                                                                   +
        "public double[] GetDiagonalSecundaria()\n"                                                                  +
        "public double[][] getArregloDeArreglo()\n"                                                                  +
        "public void sumarle(Matriz m)\n"                                                                            +
        "public void restarle(Matriz m)\n"                                                                           +
        "public void multiplicarPor(Matriz m)";

    protected override void Execute()
    {
        double[,] m1 = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9, }, };
        double[,] m2 = { { 9, 8, 7, }, { 6, 5, 4, }, { 3, 2, 1, }, };
        double[,] m3 = { { 4, 2, 6, }, { 1, 5, 3, }, { 9, 7, 8, }, };

        Matriz matriz1 = new(m1);
        Matriz matriz2 = new(m2);
        Matriz matriz3 = new(m3);

        matriz1.SetElemento(2, 1, 15);

        Console.WriteLine($"Diagonal principal de la matriz 1: {string.Join(", ", matriz1.GetDiagonalPrincipal())}");

        Console.WriteLine("Matriz 1 original:");
        matriz1.Imprimir();

        Console.WriteLine("Matriz 1 sumada con la 2:");
        matriz1.Sumarle(matriz2);
        matriz1.Imprimir();

        Console.WriteLine("Matriz 1 restada con la 3:");
        matriz1.Restarle(matriz3);
        matriz1.Imprimir();

        Console.WriteLine("Matriz 1 multiplicada por la 2:");
        matriz1.MultiplicarPor(matriz2);
        matriz1.Imprimir();
    }
}