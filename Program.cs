using SeminarioLenguajeDotnet.MenuClasses;
using SeminarioLenguajeDotnet.Practicas.Practica1;

namespace SeminarioLenguajeDotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> main = new();
            List<MenuItem> practica1 = new();

            Menu root = new("Seminario de Lenguaje .NET - Prácticas", main);
            Menu practica1Menu = new("Práctica 1", practica1, root);

            string ejercicio1Description = "Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos\r\nWriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de\r\nla misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo una\r\npausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar.\r\nTip: usar los métodos ReadKey() y Write() de la clase System.Console.";
            Ejercicio1 ejercicio1 = new(practica1Menu, ejercicio1Description);

            string ejercicio2Description = "Investigar por las secuencias de escape \\n, \\t , \\\" y \\\\. Escribir un programa que las utilice para\r\nimprimir distintos mensajes en la consola.";
            Ejercicio2 ejercicio2 = new(practica1Menu, ejercicio2Description);

            string ejercicio3Description = "El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente fragmento\r\nde código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para que el programa\r\nsiga funcionando de igual manera\n\nstring st = @\"c:\\windows\\system\";\r\nConsole.WriteLine(st);";
            Ejercicio3 ejercicio3 = new(practica1Menu, ejercicio3Description);

            string ejercicio4Description = "Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un saludo\r\npersonalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una línea en blanco.\r\nPara ingresar un string desde el teclado utilizar Console.ReadLine()";
            Ejercicio4 ejercicio4 = new(practica1Menu, ejercicio4Description);

            string ejercicio5Description = "Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el\r\nnombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María” debe\r\nimprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso, debe\r\nimprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha ingresado una línea\r\nvacía.\r\n\r\na) utilizando if ... else if\r\nb) utilizando switch";
            Ejercicio5 ejercicio5 = new(practica1Menu, ejercicio5Description);

            string ejercicio6Description = "Utilizar Console.ReadLine() para leer líneas de texto (secuencia de caracteres que finaliza al\r\npresionar <ENTER>) por la consola. Por cada línea leída se debe imprimir inmediatamente la cantidad\r\nde caracteres de la misma. El programa termina al ingresar la cadena vacía.\r\nTip: si st es una variable de tipo string, entonces st.Length devuelve la cantidad de caracteres del\r\nstring.";
            Ejercicio6 ejercicio6 = new(practica1Menu, ejercicio6Description);

            string ejercicio7Description = "Qué hace la instrucción Console.WriteLine(\"100\".Length);";
            Ejercicio7 ejercicio7 = new(practica1Menu, ejercicio7Description);

            string ejercicio8Description = "Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:\r\nConsole.WriteLine(st=Console.ReadLine());?";
            Ejercicio8 ejercicio8 = new(practica1Menu, ejercicio8Description);

            string ejercicio9Description = "Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y\r\ndeterminar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).\r\nTip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]\r\ndevuelve el último carácter de st.";
            Ejercicio9 ejercicio9 = new(practica1Menu, ejercicio9Description);

            string ejercicio10Description = "Escribir un programa que imprima en la consola todos los múltiplos de 17 o de 29 comprendidos\r\nentre 1 y 1000.";
            Ejercicio10 ejercicio10 = new(practica1Menu, ejercicio10Description);

            string ejercicio11Description = "Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y contestar\r\nlas preguntas.\r\n\r\nConsole.WriteLine(\"10/3 = \" + 10 / 3);\r\nConsole.WriteLine(\"10.0/3 = \" + 10.0 / 3);\r\nConsole.WriteLine(\"10/3.0 = \" + 10 / 3.0);\r\nint a = 10, b = 3;\r\nConsole.WriteLine(\"Si a y b son variables enteras, si a=10 y b=3\");\r\nConsole.WriteLine(\"entonces a/b = \" + a / b);\r\ndouble c = 3;\r\nConsole.WriteLine(\"Si c es una variable double, c=3\");\r\nConsole.WriteLine(\"entonces a/c = \" + a / c);\r\n\r\na) ¿Qué se puede concluir respecto del operador de división “/” ?\r\nb) ¿Cómo funciona el operador + entre un string y un dato numérico?";
            Ejercicio11 ejercicio11 = new(practica1Menu, ejercicio11Description);

            string ejercicio12Description = "Escribir un programa que imprima todos los divisores de un número entero ingresado desde la\r\nconsola. Para obtener el entero desde un string st utilizar int.Parse(st).";
            Ejercicio12 ejercicio12 = new(practica1Menu, ejercicio12Description);

            string ejercicio13Description = "Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente\r\nexpresión. Tip: observar qué pasa cuando b = 0.\r\nif ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);";
            Ejercicio13 ejercicio13 = new(practica1Menu, ejercicio13Description);

            string ejercicio14Description = "Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el\r\nmenor valor de otras dos variables enteras.";
            Ejercicio14 ejercicio14 = new(practica1Menu, ejercicio14Description);

            string ejercicio15Description = "¿Cuál es el problema del código siguiente y cómo se soluciona?\r\n\r\nint i = 0;\r\nfor (int i = 1; i <= 10;)\r\n{\r\nConsole.WriteLine(i++);\r\n}";
            Ejercicio15 ejercicio15 = new(practica1Menu, ejercicio15Description);

            string ejercicio16Description = "Analizar el siguiente código. ¿Cuál es la salida por consola?\r\n\r\nint i = 1;\r\nif (--i == 0)\r\n{\r\nConsole.WriteLine(\"cero\");\r\n}\r\nif (i++ == 0)\r\n{\r\nConsole.WriteLine(\"cero\");\r\n}\r\nConsole.WriteLine(i);";
            Ejercicio16 ejercicio16 = new(practica1Menu, ejercicio16Description);

            main.Add(new MenuItem("Práctica 1", practica1Menu.Run));

            practica1.Add(new MenuItem("Ejercicio 1", ejercicio1.Run));
            practica1.Add(new MenuItem("Ejercicio 2", ejercicio2.Run));
            practica1.Add(new MenuItem("Ejercicio 3", ejercicio3.Run));
            practica1.Add(new MenuItem("Ejercicio 4", ejercicio4.Run));
            practica1.Add(new MenuItem("Ejercicio 5", ejercicio5.Run));
            practica1.Add(new MenuItem("Ejercicio 6", ejercicio6.Run));
            practica1.Add(new MenuItem("Ejercicio 7", ejercicio7.Run));
            practica1.Add(new MenuItem("Ejercicio 8", ejercicio8.Run));
            practica1.Add(new MenuItem("Ejercicio 9", ejercicio9.Run));
            practica1.Add(new MenuItem("Ejercicio 10", ejercicio10.Run));
            practica1.Add(new MenuItem("Ejercicio 11", ejercicio11.Run));
            practica1.Add(new MenuItem("Ejercicio 12", ejercicio12.Run));
            practica1.Add(new MenuItem("Ejercicio 13", ejercicio13.Run));
            practica1.Add(new MenuItem("Ejercicio 14", ejercicio14.Run));
            practica1.Add(new MenuItem("Ejercicio 15", ejercicio15.Run));
            practica1.Add(new MenuItem("Ejercicio 16", ejercicio16.Run));

            new MenuRun(root).Run();
        }
    }
}
