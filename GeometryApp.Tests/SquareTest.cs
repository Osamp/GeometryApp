using GeometryShapes;
[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        var square = new Square(5);

        var result = square.CalculateArea();

        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var square = new Square(5);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void TestAreaWithNegativeSideLength()
    {
        var square = new Square(-5);

        var result = square.CalculateArea();

        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestPerimeterWithNegativeSideLength()
    {
        var square = new Square(-5);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(-20, result);
    }

    [TestMethod]
    public void TestPerimeterWithZeroSideLength()
    {
        // Arrange
        var square = new Square(0);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void TestAreaWithZeroSideLength()
    {
        var square = new Square(0);

        var result = square.CalculateArea();

        Assert.AreEqual(0, result);
    }
}