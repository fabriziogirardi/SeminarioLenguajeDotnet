using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio3(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un\n"                +
        "parámetro más que representa la plantilla de formato que debe aplicarse a los números al imprimirse.\n" +
        "La plantilla de formato es un string de acuerdo a las convenciones de formato compuesto, por ejemplo\n" +
        "“0.0” implica escribir los valores reales con un dígito para la parte decimal.\n\n"                     +
        "void ImprimirMatrizConFormato(double[,] matriz, string formatString)";

    protected override void Execute()
    {
        double[,] matriz = {
                               { 1.1, 1.2, 1.3, 1.4, },
                               { 2.1, 2.2, 2.3, 2.4, },
                               { 3.1, 3.2, 3.3, 3.4, },
                               { 4.1, 4.2, 4.3, 4.4, },
                           };

        ImprimirMatrizConFormato(matriz, "0.000");
    }

    private void ImprimirMatrizConFormato(double[,] matriz, string formatString)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write($"{matriz[i, j].ToString(formatString),6}");
            }

            Console.WriteLine();
        }
    }
}