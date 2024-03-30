namespace SeminarioLenguajeDotnet.Clases;

internal class Ecuacion2(int a, int b, int c)
{
    readonly private int _a = a;
    readonly private int _b = b;
    readonly private int _c = c;

    private double Discriminant => Math.Pow(_b, 2) - 4 * _a * _c;

    private int RootsCount
        => Discriminant switch {
               > 0 => 2,
               0   => 1,
               _   => 0,
           };

    private double[] Roots
        => RootsCount switch {
               2 => [
                        (-_b + Math.Sqrt(Discriminant)) / (2 * _a),
                        (-_b - Math.Sqrt(Discriminant)) / (2 * _a),
                    ],

               1 => [
                        -_b / (2 * _a),
                    ],

               _ => [],
           };

    public int GetDiscriminante() => (int)Discriminant;

    public int GetCantidadDeRaices() => RootsCount;

    public void ImprimirRaices()
    {
        if (RootsCount == 0) {
            Console.WriteLine("No hay raices reales");
            return;
        }

        Console.WriteLine($"Raices: {string.Join(", ", Roots)}");
    }
}