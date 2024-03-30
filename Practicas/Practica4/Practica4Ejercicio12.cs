using Automotores;
using Figuras;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio12(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "12) Crear una solución con tres proyectos: una biblioteca de clases llamada Automotores, una\n"       +
        "biblioteca de clases llamada Figuras y una aplicación de consola llamada Aplicacion. La biblioteca\n" +
        "Automotores debe contener una clase pública Auto (codificada de la misma manera que la vista en la\n" +
        "teoría). La biblioteca Figuras debe contener las clases públicas Circulo y Rectangulo, codificadas\n" +
        "de tal forma que el siguiente código (escrito en Program.cs del proyecto Aplicacion) produzca la\n"   +
        "siguiente salida\n\n"                                                                                 +
        "using Figuras;\n"                                                                                     +
        "using Automotores;\n\n"                                                                               +
        "//El constructor de Circulo espera recibir el radio\n"                                                +
        "List<Circulo> listaCirculos = [\n"                                                                    +
        "    new Circulo(1.1),\n"                                                                              +
        "    new Circulo(3),\n"                                                                                +
        "    new Circulo(3.2)\n"                                                                               +
        "];\n\n"                                                                                               +
        "//El constructor de Rectángulo espera recibir la base y la altura\n"                                  +
        "List<Rectangulo> listaRectangulos = [\n"                                                              +
        "    new Rectangulo(3, 4),\n"                                                                          +
        "    new Rectangulo(4.3, 4.4)\n"                                                                       +
        "];\n\n"                                                                                               +
        "//La clase Auto está codificada como la vista en la teoría\n"                                         +
        "List<Auto> listaAutos = [\n"                                                                          +
        "    new Auto(\"Nissan\", 2017),\n"                                                                    +
        "    new Auto(\"Ford\", 2015),\n"                                                                      +
        "    new Auto(\"Renault\")\n"                                                                          +
        "];\n\n"                                                                                               +
        "foreach (Circulo c in listaCirculos)\n"                                                               +
        "{\n"                                                                                                  +
        "    Console.WriteLine($\"Área del círculo {c.GetArea()}\");\n"                                        +
        "}\n"                                                                                                  +
        "foreach (Rectangulo r in listaRectangulos)\n"                                                         +
        "{\n"                                                                                                  +
        "    Console.WriteLine($\"Área del rectángulo {r.GetArea()}\");\n"                                     +
        "}\n"                                                                                                  +
        "foreach (Auto a in listaAutos)\n"                                                                     +
        "{\n"                                                                                                  +
        "    Console.WriteLine(a.GetDescripcion());\n"                                                         +
        "}\n\n"                                                                                                +
        "Salida:\n"                                                                                            +
        "Área del círculo 3,8013271108436504\n"                                                                +
        "Área del círculo 28,274333882308138\n"                                                                +
        "Área del círculo 32,169908772759484\n"                                                                +
        "Área del rectángulo 12\n"                                                                             +
        "Área del rectángulo 18,92\n"                                                                          +
        "Auto Nissan 2017\n"                                                                                   +
        "Auto Ford 2015\n"                                                                                     +
        "Auto Renault 2022";

    protected override void Execute()
    {
        //El constructor de Circulo espera recibir el radio
        List<Circulo> listaCirculos = [
                                          new Circulo(1.1),
                                          new Circulo(3),
                                          new Circulo(3.2),
                                      ];

        //El constructor de Rectángulo espera recibir la base y la altura
        List<Rectangulo> listaRectangulos = [
                                                new Rectangulo(3,   4),
                                                new Rectangulo(4.3, 4.4),
                                            ];

        //La clase Auto está codificada como la vista en la teoría
        List<Auto> listaAutos = [
                                    new Auto("Nissan", 2017),
                                    new Auto("Ford",   2015),
                                    new Auto("Renault"),
                                ];

        foreach (Circulo c in listaCirculos) {
            Console.WriteLine($"Área del círculo {c.GetArea()}");
        }

        foreach (Rectangulo r in listaRectangulos) {
            Console.WriteLine($"Área del rectángulo {r.GetArea()}");
        }

        foreach (Auto a in listaAutos) {
            Console.WriteLine(a.GetDescripcion());
        }
    }
}