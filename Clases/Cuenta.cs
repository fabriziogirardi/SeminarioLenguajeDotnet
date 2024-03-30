namespace SeminarioLenguajeDotnet.Clases;

internal class Cuenta(string? nombre = null, long? dni = null)
{
    readonly private long?   _dni    = dni;
    readonly private string? _nombre = nombre;
    private          double  _monto;

    public Cuenta(long dni) : this(null, dni) { }

    public Cuenta(string nombre) : this(nombre, null) { }

    public void Depositar(double monto) => _monto += monto;

    public void Extraer(double monto)
    {
        if (_monto - monto < 0) {
            Console.WriteLine("Operación cancelada, monto insuficiente");
            return;
        }

        _monto -= monto;
    }

    public void Imprimir()
    {
        string dni = (string.IsNullOrEmpty(_dni.ToString()) ? "No especificado" : _dni.ToString()) ?? string.Empty;
        Console.WriteLine($"Nombre: {_nombre ?? "No especificado"}, DNI: {dni}, Monto: {_monto}");
    }
}