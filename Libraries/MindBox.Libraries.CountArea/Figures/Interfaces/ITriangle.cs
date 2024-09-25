namespace MindBox.Libraries.CountArea.Figures.Interfaces
{
    public interface ITriangle: IFigure
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }
        bool IsRightTriangle ();
    }
}
