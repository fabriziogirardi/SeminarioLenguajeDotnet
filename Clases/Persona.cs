namespace SeminarioLenguajeDotnet.Clases;

internal class Persona()
{
    readonly private long    _dni;
    readonly private int     _edad;
    readonly private string? _nombre;

    public string? Nombre { get; init; }
    public int     Edad   { get; init; }
    public long    Dni    { get; init; }

    public Persona(string nombre, int edad, long dni) : this()
    {
        _nombre = nombre;
        _edad   = edad;
        _dni    = dni;
    }

    public void Imprimir()
    {
        Console.WriteLine($"{_nombre,24} {_edad,3} {_dni,12}");
    }

    public bool EsMayorQue(Persona persona) => _edad > persona._edad;
}