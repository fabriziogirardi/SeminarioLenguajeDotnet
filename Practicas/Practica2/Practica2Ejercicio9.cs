using System.Text;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio9(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos\n" +
        "implementados en el ejercicio anterior.";

    protected override void Execute()
    {
        DateTime start = DateTime.Now;
        Console.WriteLine("Inicio primer algoritmo con StringBuilder: " + start);
        StringBuilder sb = new();

        for (int i = 0; i < 100000; i++) {
            sb.Append(i);
        }

        DateTime finPrimerAlgoritmoConStringBuilder        = DateTime.Now;
        TimeSpan diferenciaPrimerAlgoritmoConStringBuilder = finPrimerAlgoritmoConStringBuilder - start;
        Console.WriteLine("Fin primer algoritmo con StringBuilder: " + finPrimerAlgoritmoConStringBuilder);
        Console.WriteLine("Tiempo de ejecución: " + diferenciaPrimerAlgoritmoConStringBuilder);

        start = DateTime.Now;
        Console.WriteLine("Inicio primer algoritmo con string: " + start);

        string s = string.Empty;

        for (int i = 0; i < 100000; i++) {
            s += i;
        }

        DateTime finPrimerAlgoritmoConString        = DateTime.Now;
        TimeSpan diferenciaPrimerAlgoritmoConString = finPrimerAlgoritmoConString - start;
        Console.WriteLine("Fin primer algoritmo con string: "                     + finPrimerAlgoritmoConString);
        Console.WriteLine("Tiempo de ejecución: "                                 + diferenciaPrimerAlgoritmoConString);

        Console.WriteLine("El tiempo de ejecución del primer algoritmo con StringBuilder es "              +
                          (diferenciaPrimerAlgoritmoConString - diferenciaPrimerAlgoritmoConStringBuilder) +
                          " menor que el segundo algoritmo con string.");

        start = DateTime.Now;
        Console.WriteLine("Inicio segundo algoritmo con StringBuilder: " + start);

        sb = new StringBuilder();
        sb.Append("Hola").Append(" ").Append("Mundo");

        DateTime finSegundoAlgoritmoConStringBuilder        = DateTime.Now;
        TimeSpan diferenciaSegundoAlgoritmoConStringBuilder = finSegundoAlgoritmoConStringBuilder - start;
        Console.WriteLine("Fin segundo algoritmo con StringBuilder: " + finSegundoAlgoritmoConStringBuilder);
        Console.WriteLine("Tiempo de ejecución: " + diferenciaSegundoAlgoritmoConStringBuilder);

        start = DateTime.Now;

        Console.WriteLine("Inicio segundo algoritmo con string: " + start);

        s =  string.Empty;
        s += "Hola" + " " + "Mundo";

        DateTime finSegundoAlgoritmoConString        = DateTime.Now;
        TimeSpan diferenciaSegundoAlgoritmoConString = finSegundoAlgoritmoConString - start;
        Console.WriteLine("Fin segundo algoritmo con string: " + finSegundoAlgoritmoConString);
        Console.WriteLine("Tiempo de ejecución: " + diferenciaSegundoAlgoritmoConString);

        Console.WriteLine("El tiempo de ejecución del segundo algoritmo con StringBuilder es "               +
                          (diferenciaSegundoAlgoritmoConString - diferenciaSegundoAlgoritmoConStringBuilder) +
                          " menor que el segundo algoritmo con string.");
    }
}