namespace GeometryShapes;
public class Triangle : IShape
{
    private double baseLength;
    private double height;
    private double sideA;
    private double sideB;

    public Triangle(double baseLength, double height, double sideA, double sideB)
    {
        this.baseLength = baseLength;
        this.height = height;
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }

    public double CalculatePerimeter()
    {
        return baseLength + sideA + sideB;
    }
}