using MindBox.Libraries.CountArea.Figures.Interfaces;

namespace MindBox.Libraries.CountArea.Figures
{
    public class Triangle: ITriangle
    {
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0)
                throw new ArgumentException("Неверно указана сторона трекгольника");
            if (edgeC <= 0)
                throw new ArgumentException("Неверно указана сторона трекгольника");
            if (edgeB <= 0)
                throw new ArgumentException("Неверно указана сторона трекгольника");
            double maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            if (maxEdge > edgeC + edgeA + edgeB - maxEdge)
                throw new ArgumentException("Сторона треугольника не может быть больше суммы двух других");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }
        public double GetArea()
        {
            double p = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
        }
        public bool IsRightTriangle()
        {
            double max = EdgeA, b = EdgeB, c = EdgeC;
            if (max < b)
            {
                max += b;
                b = max - b;
                max = max - b;
            }
            if (max < c)
            {
                max += c;
                c = max - c;
                max = max - c;
            }
            return Math.Pow(max, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
    }
}
