using SeminarioLenguajeDotnet.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.Practicas.Practica1
{
    internal class Ejercicio9 : Practica
    {
        public Ejercicio9(Menu parent, string description) : base(parent, description)
        {
        }

        public override void Execute()
        {
            Console.Write("Escriba 2 palabras separadas por un espacio: ");
            string? str = Console.ReadLine();

            if (str.Length % 2 == 0) {
                Console.WriteLine("Las palabras tienen distinta logitud, jamás serán simétricas. No se evaluarán los caracteres de manera individual.");
            } else {
                string[] words = str.Split(' ');
                if (words.Length != 2) {
                    Console.WriteLine("Debe escribir 2 palabras separadas por un espacio.");
                } else {
                    string word1 = words[0];
                    string word2 = words[1];
                    bool areSymmetric = true;
                    for (int i = 0; i < word1.Length; i++) {
                        if (word1[i] != word2[word2.Length - 1 - i]) {
                            areSymmetric = false;
                            break;
                        }
                    }

                    if (areSymmetric) {
                        Console.WriteLine("Las palabras son simétricas.");
                    } else {
                        Console.WriteLine("Las palabras no son simétricas.");
                    }
                }
            }
        }
    }
}
