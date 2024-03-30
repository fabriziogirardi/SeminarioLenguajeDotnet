namespace SeminarioLenguajeDotnet.Clases;

internal class Hora()
{
    readonly private bool   _conDecimales;
    readonly private int    _hora;
    readonly private int    _minuto;
    readonly private int    _segundo;
    readonly private double _segundoConDecimales;

    public Hora(int hora, int minuto, int segundo) : this()
    {
        _hora    = hora;
        _minuto  = minuto;
        _segundo = segundo;
    }

    public Hora(double hora) : this()
    {
        _hora                = (int)hora;
        _minuto              = (int)((hora - _hora) * 60);
        _segundoConDecimales = ((hora - _hora) * 60 - _minuto) * 60;
        _conDecimales        = true;
    }

    public void Imprimir()
    {
        Console.WriteLine(_conDecimales
                              ? $"{_hora} horas, {_minuto} minutos y {_segundoConDecimales:0.000} segundos"
                              : $"{_hora} horas, {_minuto} minutos y {_segundo} segundos");
    }
}