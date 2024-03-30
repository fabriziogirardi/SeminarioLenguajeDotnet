namespace Figuras;

public class Circulo(double radio)
{
    readonly private double _radio = radio;

    public double GetArea() => Math.PI * Math.Pow(_radio, 2);
}