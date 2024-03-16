using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica1;

internal class Practica1Ejercicio9(Menu parent) : Practica(parent)
{
    public override string Description { get; protected set; } =
        "Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y\r\n" +
        "determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).\r\n"                        +
        "Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]\r\n"  +
        "devuelve el último carácter de st.";

    protected override void Execute()
    {
        Console.Write("Escriba 2 palabras separadas por un espacio: ");
        string str = Console.ReadLine() ?? string.Empty;

        string[] words = str.Split(' ');

        if (words.Length != 2) {
            Console.WriteLine("Debe escribir 2 palabras separadas por un espacio.");
            return;
        }

        string word1 = words[0];
        string word2 = words[1];

        if (word1.Length != word2.Length) {
            Console.WriteLine("Las palabras no tienen la misma longitud, es imposible que sean simétricas.");
            return;
        }

        if (word1.Where((t, i) => t != word2[word2.Length - 1 - i]).Any()) {
            Console.WriteLine("Las palabras no son simétricas.");
            return;
        }

        Console.WriteLine("Las palabras son simétricas.");
    }
}