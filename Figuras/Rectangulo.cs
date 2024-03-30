namespace Figuras;

public class Rectangulo(double lado1, double lado2)
{
    readonly private double _lado1 = lado1;
    readonly private double _lado2 = lado2;

    public double GetArea() => _lado1 * _lado2;
}