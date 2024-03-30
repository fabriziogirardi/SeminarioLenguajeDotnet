using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio2(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Modificar el programa anterior haciendo privados todos los campos. Definir un constructor adecuado\n" +
        "y un método público Imprimir() que escriba en la consola los campos del objeto con el formato\n"      +
        "requerido para el listado.";

    protected override void Execute()
    {
        string[] lines = new StreamReader("Archivos/Personas.txt").ReadToEnd().Split("\n");

        Persona[] personas = new Persona[lines.Length];

        for (int i = 0; i < lines.Length; i++) {
            string[] data = lines[i].Split(",");

            personas[i] = new Persona(data[0], int.Parse(data[1]), long.Parse(data[2]));
        }

        foreach (Persona persona in personas) {
            persona.Imprimir();
        }
    }
}