
namespace Square
{
    internal class Figure
    {
        internal double[,] coordinates;
        internal double SquareCalculation (double[,] coordinates)
        {
            double x1, x2, x3, y1, y2, y3;
            double a, b, c;
            double halfPerimeter, square = 0;
            x1 = coordinates[0, 0];
            y1 = coordinates[1, 0];
            for (int i = 1; i < coordinates.GetLength(1) - 1; i++)
            {
                x2 = coordinates[0, i];
                y2 = coordinates[1, i];
                x3 = coordinates[0, i + 1];
                y3 = coordinates[1, i + 1];
                a = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                b = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));
                c = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                halfPerimeter = (a + b + c) / 2;
                square += Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }
            return square;
        }
    }
}
