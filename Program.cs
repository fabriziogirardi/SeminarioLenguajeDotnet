using System.Text;
using SeminarioLenguajeDotnet.MenuClasses;
using SeminarioLenguajeDotnet.Practicas.Practica1;
using SeminarioLenguajeDotnet.Practicas.Practica2;
using SeminarioLenguajeDotnet.Practicas.Practica3;

namespace SeminarioLenguajeDotnet;

abstract internal class Program
{
    static private void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        List<MenuItem> main      = [];
        List<MenuItem> practica1 = [];
        List<MenuItem> practica2 = [];
        List<MenuItem> practica3 = [];

        Menu root          = new("Seminario de Lenguaje .NET - Prácticas", main);
        Menu practica1Menu = new("Práctica 1", practica1, root);
        Menu practica2Menu = new("Práctica 2", practica2, root);
        Menu practica3Menu = new("Práctica 3", practica3, root);

        #region Practica 1
        Practica1Ejercicio1  practica1Ejercicio1  = new(practica1Menu);
        Practica1Ejercicio2  practica1Ejercicio2  = new(practica1Menu);
        Practica1Ejercicio3  practica1Ejercicio3  = new(practica1Menu);
        Practica1Ejercicio4  practica1Ejercicio4  = new(practica1Menu);
        Practica1Ejercicio5  practica1Ejercicio5  = new(practica1Menu);
        Practica1Ejercicio6  practica1Ejercicio6  = new(practica1Menu);
        Practica1Ejercicio7  practica1Ejercicio7  = new(practica1Menu);
        Practica1Ejercicio8  practica1Ejercicio8  = new(practica1Menu);
        Practica1Ejercicio9  practica1Ejercicio9  = new(practica1Menu);
        Practica1Ejercicio10 practica1Ejercicio10 = new(practica1Menu);
        Practica1Ejercicio11 practica1Ejercicio11 = new(practica1Menu);
        Practica1Ejercicio12 practica1Ejercicio12 = new(practica1Menu);
        Practica1Ejercicio13 practica1Ejercicio13 = new(practica1Menu);
        Practica1Ejercicio14 practica1Ejercicio14 = new(practica1Menu);
        Practica1Ejercicio15 practica1Ejercicio15 = new(practica1Menu);
        Practica1Ejercicio16 practica1Ejercicio16 = new(practica1Menu);
        #endregion

        #region Practica 2
        Practica2Ejercicio1  practica2Ejercicio1  = new(practica2Menu);
        Practica2Ejercicio2  practica2Ejercicio2  = new(practica2Menu);
        Practica2Ejercicio3  practica2Ejercicio3  = new(practica2Menu);
        Practica2Ejercicio4  practica2Ejercicio4  = new(practica2Menu);
        Practica2Ejercicio5  practica2Ejercicio5  = new(practica2Menu);
        Practica2Ejercicio6  practica2Ejercicio6  = new(practica2Menu);
        Practica2Ejercicio7  practica2Ejercicio7  = new(practica2Menu);
        Practica2Ejercicio8  practica2Ejercicio8  = new(practica2Menu);
        Practica2Ejercicio9  practica2Ejercicio9  = new(practica2Menu);
        Practica2Ejercicio10 practica2Ejercicio10 = new(practica2Menu);
        Practica2Ejercicio11 practica2Ejercicio11 = new(practica2Menu);
        Practica2Ejercicio12 practica2Ejercicio12 = new(practica2Menu);
        Practica2Ejercicio13 practica2Ejercicio13 = new(practica2Menu);
        Practica2Ejercicio14 practica2Ejercicio14 = new(practica2Menu);
        Practica2Ejercicio15 practica2Ejercicio15 = new(practica2Menu);
        Practica2Ejercicio16 practica2Ejercicio16 = new(practica2Menu, args);
        Practica2Ejercicio17 practica2Ejercicio17 = new(practica2Menu, args);
        Practica2Ejercicio18 practica2Ejercicio18 = new(practica2Menu, args);
        Practica2Ejercicio19 practica2Ejercicio19 = new(practica2Menu, args);
        Practica2Ejercicio20 practica2Ejercicio20 = new(practica2Menu);
        Practica2Ejercicio21 practica2Ejercicio21 = new(practica2Menu);
        #endregion

        #region Practica 3
        Practica3Ejercicio1  practica3Ejercicio1  = new(practica3Menu);
        Practica3Ejercicio2  practica3Ejercicio2  = new(practica3Menu);
        Practica3Ejercicio3  practica3Ejercicio3  = new(practica3Menu);
        Practica3Ejercicio4  practica3Ejercicio4  = new(practica3Menu);
        Practica3Ejercicio5  practica3Ejercicio5  = new(practica3Menu);
        Practica3Ejercicio6  practica3Ejercicio6  = new(practica3Menu);
        Practica3Ejercicio7  practica3Ejercicio7  = new(practica3Menu);
        Practica3Ejercicio8  practica3Ejercicio8  = new(practica3Menu);
        Practica3Ejercicio9  practica3Ejercicio9  = new(practica3Menu);
        Practica3Ejercicio10 practica3Ejercicio10 = new(practica3Menu);
        Practica3Ejercicio11 practica3Ejercicio11 = new(practica3Menu);
        Practica3Ejercicio12 practica3Ejercicio12 = new(practica3Menu);
        Practica3Ejercicio13 practica3Ejercicio13 = new(practica3Menu);
        Practica3Ejercicio14 practica3Ejercicio14 = new(practica3Menu);
        Practica3Ejercicio15 practica3Ejercicio15 = new(practica3Menu);
        Practica3Ejercicio16 practica3Ejercicio16 = new(practica3Menu);
        Practica3Ejercicio17 practica3Ejercicio17 = new(practica3Menu);
        #endregion

        main.Add(new MenuItem("Práctica 1", practica1Menu.Run));
        main.Add(new MenuItem("Práctica 2", practica2Menu.Run));
        main.Add(new MenuItem("Práctica 3", practica3Menu.Run));

        #region Practica 1 items
        practica1.Add(new MenuItem("Ejercicio 1",  practica1Ejercicio1.Run));
        practica1.Add(new MenuItem("Ejercicio 2",  practica1Ejercicio2.Run));
        practica1.Add(new MenuItem("Ejercicio 3",  practica1Ejercicio3.Run));
        practica1.Add(new MenuItem("Ejercicio 4",  practica1Ejercicio4.Run));
        practica1.Add(new MenuItem("Ejercicio 5",  practica1Ejercicio5.Run));
        practica1.Add(new MenuItem("Ejercicio 6",  practica1Ejercicio6.Run));
        practica1.Add(new MenuItem("Ejercicio 7",  practica1Ejercicio7.Run));
        practica1.Add(new MenuItem("Ejercicio 8",  practica1Ejercicio8.Run));
        practica1.Add(new MenuItem("Ejercicio 9",  practica1Ejercicio9.Run));
        practica1.Add(new MenuItem("Ejercicio 10", practica1Ejercicio10.Run));
        practica1.Add(new MenuItem("Ejercicio 11", practica1Ejercicio11.Run));
        practica1.Add(new MenuItem("Ejercicio 12", practica1Ejercicio12.Run));
        practica1.Add(new MenuItem("Ejercicio 13", practica1Ejercicio13.Run));
        practica1.Add(new MenuItem("Ejercicio 14", practica1Ejercicio14.Run));
        practica1.Add(new MenuItem("Ejercicio 15", practica1Ejercicio15.Run));
        practica1.Add(new MenuItem("Ejercicio 16", practica1Ejercicio16.Run));
        #endregion

        #region Practica 2 items
        practica2.Add(new MenuItem("Ejercicio 1",  practica2Ejercicio1.Run));
        practica2.Add(new MenuItem("Ejercicio 2",  practica2Ejercicio2.Run));
        practica2.Add(new MenuItem("Ejercicio 3",  practica2Ejercicio3.Run));
        practica2.Add(new MenuItem("Ejercicio 4",  practica2Ejercicio4.Run));
        practica2.Add(new MenuItem("Ejercicio 5",  practica2Ejercicio5.Run));
        practica2.Add(new MenuItem("Ejercicio 6",  practica2Ejercicio6.Run));
        practica2.Add(new MenuItem("Ejercicio 7",  practica2Ejercicio7.Run));
        practica2.Add(new MenuItem("Ejercicio 8",  practica2Ejercicio8.Run));
        practica2.Add(new MenuItem("Ejercicio 9",  practica2Ejercicio9.Run));
        practica2.Add(new MenuItem("Ejercicio 10", practica2Ejercicio10.Run));
        practica2.Add(new MenuItem("Ejercicio 11", practica2Ejercicio11.Run));
        practica2.Add(new MenuItem("Ejercicio 12", practica2Ejercicio12.Run));
        practica2.Add(new MenuItem("Ejercicio 13", practica2Ejercicio13.Run));
        practica2.Add(new MenuItem("Ejercicio 14", practica2Ejercicio14.Run));
        practica2.Add(new MenuItem("Ejercicio 15", practica2Ejercicio15.Run));
        practica2.Add(new MenuItem("Ejercicio 16", practica2Ejercicio16.Run));
        practica2.Add(new MenuItem("Ejercicio 17", practica2Ejercicio17.Run));
        practica2.Add(new MenuItem("Ejercicio 18", practica2Ejercicio18.Run));
        practica2.Add(new MenuItem("Ejercicio 19", practica2Ejercicio19.Run));
        practica2.Add(new MenuItem("Ejercicio 20", practica2Ejercicio20.Run));
        practica2.Add(new MenuItem("Ejercicio 21", practica2Ejercicio21.Run));
        #endregion

        #region Practica 3 items
        practica3.Add(new MenuItem("Ejercicio 1",  practica3Ejercicio1.Run));
        practica3.Add(new MenuItem("Ejercicio 2",  practica3Ejercicio2.Run));
        practica3.Add(new MenuItem("Ejercicio 3",  practica3Ejercicio3.Run));
        practica3.Add(new MenuItem("Ejercicio 4",  practica3Ejercicio4.Run));
        practica3.Add(new MenuItem("Ejercicio 5",  practica3Ejercicio5.Run));
        practica3.Add(new MenuItem("Ejercicio 6",  practica3Ejercicio6.Run));
        practica3.Add(new MenuItem("Ejercicio 7",  practica3Ejercicio7.Run));
        practica3.Add(new MenuItem("Ejercicio 8",  practica3Ejercicio8.Run));
        practica3.Add(new MenuItem("Ejercicio 9",  practica3Ejercicio9.Run));
        practica3.Add(new MenuItem("Ejercicio 10", practica3Ejercicio10.Run));
        practica3.Add(new MenuItem("Ejercicio 11", practica3Ejercicio11.Run));
        practica3.Add(new MenuItem("Ejercicio 12", practica3Ejercicio12.Run));
        practica3.Add(new MenuItem("Ejercicio 13", practica3Ejercicio13.Run));
        practica3.Add(new MenuItem("Ejercicio 14", practica3Ejercicio14.Run));
        practica3.Add(new MenuItem("Ejercicio 15", practica3Ejercicio15.Run));
        practica3.Add(new MenuItem("Ejercicio 16", practica3Ejercicio16.Run));
        practica3.Add(new MenuItem("Ejercicio 17", practica3Ejercicio17.Run));
        #endregion

        new MenuRun(root).Run();
    }
}