 using GeometryShapes;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestAreaWithPositiveWidthAndLength()
    {
        var rectangle = new Rectangle(5, 10);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(50, result);
    }

    [TestMethod]
    public void TestPerimeterWithPositiveWidthAndLength()
    {
        var rectangle = new Rectangle(5, 10);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(30, result);
    }

    [TestMethod]
    public void TestAreaWithZeroWidthAndPositiveLength()
    {
        var rectangle = new Rectangle(0, 10);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestPerimeterWithZeroWidthAndPositiveLength()
    {
        var rectangle = new Rectangle(0, 10);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void TestAreaWithPositiveWidthAndZeroLength()
    {
        var rectangle = new Rectangle(5, 0);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestPerimeterWithPositiveWidthAndZeroLength()
    {
        var rectangle = new Rectangle(5, 0);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(10, result);
    }
}



