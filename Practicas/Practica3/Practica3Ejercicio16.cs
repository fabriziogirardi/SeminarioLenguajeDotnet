using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio16(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Implementar un programa que permita al usuario ingresar números por la consola. Debe ingresarse\n"      +
        "un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía. A medida que se\n" +
        "van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.\n"   +
        "Utilizar double.Parse() y try/catch para validar que la entrada ingresada sea un número válido,\n"      +
        "en caso contrario advertir con un mensaje al usuario y proseguir con el ingreso de datos.";

    protected override void Execute()
    {
        double sum   = 0;
        string input = Console.ReadLine() ?? "";

        while (!string.IsNullOrEmpty(input)) {
            try {
                sum += double.Parse(input.Replace('.', ','));
                Console.WriteLine($"Suma acumulada: {sum}");
            }
            catch (FormatException) {
                Console.WriteLine("El valor ingresado no es un número válido, intente nuevamente.");
            }

            input = Console.ReadLine() ?? "";
        }
    }
}