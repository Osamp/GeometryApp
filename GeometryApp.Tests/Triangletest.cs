using GeometryShapes;

[TestClass]

public class Triangletest
{

    [TestMethod]
    public void Test_Isoceles_Triangles_Correct_Area()
    {
        var triangle = new Triangle(4, 5, 4, 3); 

        var area = triangle.CalculateArea();

        Assert.AreEqual(10, area, "Area should be correct for specified height and base");
    }

    [TestMethod]
    public void Test_Isoceles_Triangles_Correct_Perimeter()
    {
        var triangle = new Triangle(4, 5, 4, 3); 

        var perimeter = triangle.CalculatePerimeter();

        Assert.AreEqual(11, perimeter, "Perimeter should be the sum of sides");
    }

    [TestMethod]
    public void Test_Equilateral_Triangle_CorrectArea()
    {
    
        var triangle = new Triangle(5, (Math.Sqrt(75) / 2), 5, 5); 

        var area = triangle.CalculateArea();

        Assert.AreEqual(10.825317547305485, area, "Area should be consistent for equilateral triangle");
    }

    [TestMethod]
    public void Test_Equilateral_Triangle_Correct_Perimeter()
    {
        var triangle = new Triangle(5, (Math.Sqrt(75) / 2), 5, 5);

        var perimeter = triangle.CalculatePerimeter();

        Assert.AreEqual(15, perimeter, "Perimeter should be thrice the side length");
    }

    [TestMethod]
    public void Test_Triangle_With_A_Negative_Dimension_Negative_Area()
    {

        var triangle = new Triangle(-3, 4, 5, 6);

        var area = triangle.CalculateArea();

        Assert.AreEqual(-6, area, "Area should be negative due to negative base");
    }

    [TestMethod]
    public void Test_Triangle_With_Negative_Dimensions_Correct_Perimeter()
    {

        var triangle = new Triangle(-3, 4, 5, 6);

        var perimeter = triangle.CalculatePerimeter();

        Assert.AreEqual(8, perimeter, "Perimeter calculation ignores the sign of base");
    }

    
}

