namespace SeminarioLenguajeDotnet.Clases;

internal class Matriz()
{
    private double[,] _matrix = new double[0, 0];

    public Matriz(int rows, int cols) : this()
    {
        _matrix = new double[rows, cols];
    }

    public Matriz(double[,] matrix) : this()
    {
        _matrix = matrix;
    }

    public void SetElemento(int row, int col, double value) => _matrix[row, col] = value;

    public double GetElemento(int row, int col) => _matrix[row, col];

    public void Imprimir()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++) {
            for (int j = 0; j < _matrix.GetLength(1); j++) {
                Console.Write($"{_matrix[i, j]}\t");
            }

            Console.WriteLine();
        }
    }

    public void Imprimir(string formatString)
    {
        for (int i = 0; i < _matrix.GetLength(0); i++) {
            for (int j = 0; j < _matrix.GetLength(1); j++) {
                Console.Write($"{_matrix[i, j].ToString(formatString)}\t");
            }

            Console.WriteLine();
        }
    }

    public double[] GetFila(int row)
    {
        int cols = _matrix.GetLength(1);

        double[] fila = new double[cols];

        for (int i = 0; i < cols; i++) {
            fila[i] = _matrix[row, i];
        }

        return fila;
    }

    public double[] GetColumna(int col)
    {
        int rows = _matrix.GetLength(0);

        double[] columna = new double[rows];

        for (int i = 0; i < rows; i++) {
            columna[i] = _matrix[i, col];
        }

        return columna;
    }

    public double[] GetDiagonalPrincipal()
    {
        if (_matrix.GetLength(0) != _matrix.GetLength(1)) {
            throw new InvalidOperationException("La matriz no es cuadrada, no tiene diagonal principal.");
        }

        int rows = _matrix.GetLength(0);
        int cols = _matrix.GetLength(1);

        double[] diagonal = new double[Math.Min(rows, cols)];

        for (int i = 0; i < diagonal.Length; i++) {
            diagonal[i] = _matrix[i, i];
        }

        return diagonal;
    }

    public double[] GetDiagonalSecundaria()
    {
        if (_matrix.GetLength(0) != _matrix.GetLength(1)) {
            throw new InvalidOperationException("La matriz no es cuadrada, no tiene diagonal secundaria.");
        }

        int rows = _matrix.GetLength(0);
        int cols = _matrix.GetLength(1);

        double[] diagonal = new double[Math.Min(rows, cols)];

        for (int i = 0; i < diagonal.Length; i++) {
            diagonal[i] = _matrix[i, cols - i - 1];
        }

        return diagonal;
    }

    public double[][] GetArregloDeArreglo()
    {
        int rows = _matrix.GetLength(0);
        int cols = _matrix.GetLength(1);

        double[][] arreglo = new double[rows][];

        for (int i = 0; i < rows; i++) {
            arreglo[i] = new double[cols];

            for (int j = 0; j < cols; j++) {
                arreglo[i][j] = _matrix[i, j];
            }
        }

        return arreglo;
    }

    public void Sumarle(Matriz m)
    {
        for (int i = 0; i < _matrix.GetLength(0); i++) {
            for (int j = 0; j < _matrix.GetLength(1); j++) {
                _matrix[i, j] += m.GetElemento(i, j);
            }
        }
    }

    public void Restarle(Matriz m)
    {
        for (int i = 0; i < _matrix.GetLength(0); i++) {
            for (int j = 0; j < _matrix.GetLength(1); j++) {
                _matrix[i, j] -= m.GetElemento(i, j);
            }
        }
    }

    public void MultiplicarPor(Matriz m)
    {
        if (_matrix.GetLength(1) != m._matrix.GetLength(0)) {
            throw new InvalidOperationException("No se pueden multiplicar las matrices.");
        }

        double[,] result = new double[_matrix.GetLength(0), m._matrix.GetLength(1)];

        for (int i = 0; i < _matrix.GetLength(0); i++) {
            for (int j = 0; j < m._matrix.GetLength(1); j++) {
                for (int k = 0; k < _matrix.GetLength(1); k++) {
                    result[i, j] += _matrix[i, k] * m._matrix[k, j];
                }
            }
        }

        _matrix = result;
    }
}