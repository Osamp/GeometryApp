 using GeometryShapes;

[TestClass]
public class Rectangletest
{
    [TestMethod]
    public void Test_Area_With_Positive_Width_And_Length()
    {
        var rectangle = new Rectangle(5, 10);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(50, result);
    }

    [TestMethod]
    public void Test_Perimeter_With_Positive_Width_And_Length()
    {
        var rectangle = new Rectangle(5, 10);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(30, result);
    }

    [TestMethod]
    public void Test_Area_With_Zero_Width_And_Positive_Length()
    {
        var rectangle = new Rectangle(0, 10);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Test_Perimeter_With_Zero_Width_And_Positive_Length()
    {
        var rectangle = new Rectangle(0, 10);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Test_Area_With_Positive_Width_And_Zero_Length()
    {
        var rectangle = new Rectangle(5, 0);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Test_Perimeter_With_Positive_Width_And_Zero_Length()
    {
        var rectangle = new Rectangle(5, 0);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(10, result);
    }
}



