using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica3;

internal class Practica3Ejercicio12(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están\n" +
        "bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena de\n" +
        "entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se almacenan en una\n" +
        "pila hasta encontrar uno de cierre, realizándose entonces la extracción del último paréntesis de apertura\n" +
        "almacenado. Si durante el proceso se lee un paréntesis de cierre y la pila está vacía, entonces la cadena\n" +
        "es incorrecta. Al finalizar el análisis, la pila debe quedar vacía para que la cadena leída sea aceptada, de\n" +
        "lo contrario la misma no es válida.";

    protected override void Execute()
    {
        Console.WriteLine("Introduce una expresión aritmética con paréntesis para verificar si los paréntesis están balanceados:");
        string expression = Console.ReadLine() ?? "";

        Console.WriteLine(IsBalanced(expression)
                              ? "Los paréntesis están balanceados."
                              : "Los paréntesis no están balanceados.");
    }

    static private bool IsBalanced(string expression)
    {
        Stack<char> stack = new();

        foreach (char c in expression) {
            if (c == '(') {
                stack.Push(c);
            } else if (c == ')') {
                if (stack.Count == 0) {
                    return false;
                }

                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}