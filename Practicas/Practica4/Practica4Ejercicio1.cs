using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio1(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un algoritmo que\n"   +
        "permita al usuario ingresar en una consola una serie de datos de esta forma:\n"                     +
        "Nombre,Documento,Edad <ENTER>.\n\n"                                                                 +
        "Una vez finalizada la entrada de datos, el programa debe imprimir en la consola un listado con 4\n" +
        "columnas de la siguiente forma:\n"                                                                  +
        "Nro)\tNombre\tEdad\tDNI.\n"                                                                         +
        "Ejemplo de listado por consola:\n"                                                                  +
        "1)\tJuan Perez\t40\t2098745\n"                                                                      +
        "2)\tJosé García\t41\t1965412\n\n"                                                                   +
        "NOTA: Se puede utilizar: Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));\n"             +
        "para cambiar la entrada estándar de la consola y poder leer directamente desde un archivo de texto.";

    protected override void Execute()
    {
        string[] lines = new StreamReader("Archivos/Personas.txt").ReadToEnd().Split("\n");

        Persona[] personas = new Persona[lines.Length];

        for (int i = 0; i < lines.Length; i++) {
            string[] data = lines[i].Split(",");

            personas[i] = new Persona {
                                          Nombre = data[0],
                                          Edad   = int.Parse(data[1]),
                                          Dni    = long.Parse(data[2]),
                                      };
        }

        foreach (Persona persona in personas) {
            Console.WriteLine($"{persona.Nombre,24} {persona.Edad,3} {persona.Dni,12}");
        }
    }
}