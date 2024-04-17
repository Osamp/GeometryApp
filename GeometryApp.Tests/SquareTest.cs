using GeometryShapes;

[TestClass]
public class Squaretest
{
    [TestMethod]
    public void Test_Squares_Area_for_Valid_Side_Length()
    {
        var square = new Square(5);

        var result = square.CalculateArea();

        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Test_Squares_Perimeter_for_Valid_Side_Length()
    {
        var square = new Square(5);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Test_Area_With_Negative_Side_Length()
    {
        var square = new Square(-5);

        var result = square.CalculateArea();

        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void Test_Perimeter_With_Negative_Side_Length()
    {
        var square = new Square(-5);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(-20, result);
    }

    [TestMethod]
    public void Test_Perimeter_With_Zero_Side_Length()
    {
        var square = new Square(0);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Test_Area_With_Zero_Side_Length()
    {
        var square = new Square(0);

        var result = square.CalculateArea();

        Assert.AreEqual(0, result);
    }
}