namespace Automotores;

public class Auto(string marca, int modelo)
{
    readonly private string _marca  = marca;
    readonly private int    _modelo = modelo;

    public Auto() : this("Fiat", DateTime.Now.Year) { }

    public Auto(string marca) : this(marca, DateTime.Now.Year) { }

    public string GetDescripcion() => $"Auto {_marca} {_modelo}";
}