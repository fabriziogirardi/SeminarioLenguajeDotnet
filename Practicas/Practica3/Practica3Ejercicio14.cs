using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio14(Menu menu) : Practica(menu)
{
    readonly private char[] _table = [
                                         'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                         'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y',
                                         'Z', ' ',
                                     ];

    public override string Description { get; protected set; } =
        "Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto\n"                 +
        "aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter\n" +
        "una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por ejemplo: para\n"    +
        "la siguiente tabla de caracteres:\n"                                                                          +
        "Si la clave es 5,3,9,7 y el mensaje a cifrar es “HOLA MUNDO”, se cifra de la siguiente manera:\n"             +
        "A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que la suma\n"   +
        "fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola con los números\n"        +
        "de la clave encolados y a medida que se desencolen para utilizarlos en el cifrado, se vuelvan a encolar\n"    +
        "para su posterior utilización. Programar un método para cifrar y otro para descifrar.\n"                      +
        "A B C D E F G H I J K L M N Ñ O P Q R S T U V W X Y Z sp\n"                                                   +
        "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28\n"                                 +
        "H O L A sp M U N D O <- Mensaje original\n"                                                                   +
        "8 16 12 1 28 13 22 14 4 16 <- Código sin cifrar\n"                                                            +
        "5 3 9 7 5 3 9 7 5 3 <- Clave repetida\n"                                                                      +
        "13 19 21 8 5 16 3 21 9 19 <- Código cifrado\n"                                                                +
        "M R T H E O C T I R <- Mensaje cifrado";

    protected override void Execute()
    {
        Console.WriteLine("Introduce la clave para cifrar el mensaje:");
        string key = Console.ReadLine() ?? "";

        Console.WriteLine("Introduce el mensaje a cifrar:");
        string message = Console.ReadLine() ?? "";

        string encryptedMessage = Encrypt(message, key);
        Console.WriteLine($"Mensaje cifrado: {encryptedMessage}");

        string decryptedMessage = Decrypt(encryptedMessage, key);
        Console.WriteLine($"Mensaje descifrado: {decryptedMessage}");
    }

    private string Encrypt(string message, string key)
    {
        Queue<int> queue = new();

        foreach (char c in key) {
            if (char.IsDigit(c)) {
                queue.Enqueue(int.Parse(c.ToString()));
            }
        }

        string result = "";

        foreach (char c in message) {
            char tmp = char.ToUpper(c);

            if (char.IsLetter(tmp) || char.IsWhiteSpace(tmp)) {
                int shift = queue.Dequeue();
                int pos   = Array.IndexOf(_table, tmp);
                int code  = pos + shift;

                if (code >= _table.Length) {
                    code -= _table.Length;
                }

                result += _table[code];
                queue.Enqueue(shift);
            } else {
                result += c;
            }
        }

        return result;
    }

    private string Decrypt(string message, string key)
    {
        Queue<int> queue = new();

        foreach (char c in key) {
            if (char.IsDigit(c)) {
                queue.Enqueue(int.Parse(c.ToString()));
            }
        }

        string result = "";

        foreach (char c in message) {
            char tmp = char.ToUpper(c);

            if (char.IsLetter(c) || char.IsWhiteSpace(c)) {
                int shift = queue.Dequeue();
                int pos   = Array.IndexOf(_table, tmp);
                int code  = pos - shift;

                if (code < 0) {
                    code += _table.Length;
                }

                result += _table[code];
                queue.Enqueue(shift);
            } else {
                result += c;
            }
        }

        return result;
    }
}