using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica2;

internal class Practica2Ejercicio3(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "¿Qué diferencias existen entre las conversiones de tipo implícitas y explícitas?";

    protected override void Execute()
    {
        Console.WriteLine("La diferencia entre las conversiones de tipo implícitas y explícitas"                       +
                          " es que las conversiones implícitas se realizan de forma automática por el compilador,"     +
                          " mientras que las conversiones explícitas se realizan de forma manual por el programador."  +
                          " Las conversiones implícitas se realizan cuando no hay riesgo de convertir un tipo de dato" +
                          " en otro, mientras que las conversiones explícitas requieren que el programador indique"    +
                          " que desea realizar una conversión y le corresponde a él asegurarse de que sea segura.");
    }
}