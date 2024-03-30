using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio3(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la\n"             +
        "persona que recibe el mensaje tiene más edad que la persona enviada como parámetro. Utilizarlo para\n" +
        "realizar un programa que devuelva la persona más jóven de la lista.";

    protected override void Execute()
    {
        string[] lines = new StreamReader("Archivos/Personas.txt").ReadToEnd().Split("\n");

        Persona[] personas = new Persona[lines.Length];

        for (int i = 0; i < lines.Length; i++) {
            string[] data = lines[i].Split(",");

            personas[i] = new Persona(data[0], int.Parse(data[1]), long.Parse(data[2]));
        }

        Persona personaMasJoven = personas[0];

        foreach (Persona persona in personas) {
            if (!persona.EsMayorQue(personaMasJoven)) {
                personaMasJoven = persona;
            }
        }

        personaMasJoven.Imprimir();
    }
}