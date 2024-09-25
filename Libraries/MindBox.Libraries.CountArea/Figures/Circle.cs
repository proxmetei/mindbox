using MindBox.Libraries.CountArea.Figures.Interfaces;

namespace MindBox.Libraries.CountArea.Figures
{
    public class Circle: ICircle
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неправильный радиус");
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
