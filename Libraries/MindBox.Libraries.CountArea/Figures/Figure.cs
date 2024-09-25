using MindBox.Libraries.CountArea.Figures.Interfaces;

namespace MindBox.Libraries.CountArea.Figures
{
    public class Figure: IFigure
    {
        private IFigure figure;

        public Figure(IFigure figure)
        {
            this.figure = figure;
        }
        public double GetArea()
        {
            return figure.GetArea();
        }
    }
}
