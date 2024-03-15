using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas;

abstract internal class Practica(Menu parent)
{
    private Menu Parent { get; } = parent;

    abstract public string Description { get; protected set; }

    abstract protected void Execute();

    public void Run()
    {
        ShowText();
        Execute();
        Return();
    }

    private void ShowText()
    {
        Console.Clear();
        Console.WriteLine("Consigna:");
        Console.WriteLine(Description);
        Console.WriteLine();
        Console.WriteLine("Resolución:");
        Console.WriteLine();
    }

    private void Return()
    {
        Console.WriteLine();
        Console.WriteLine("Ejericio completado.");
        Console.WriteLine("Presione cualquier tecla para volver a la lista anterior.");
        Console.ReadKey(true);
        Parent.Run();
    }
}