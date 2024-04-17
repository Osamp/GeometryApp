using GeometryShapes;

[TestMethod]
public void TestIsocelesTriangle()
{
    // Arrange
    var triangle = new Triangle(4, 5, 4, 3); // base=4, height=5 (correct height for the isosceles triangle with sides 4, 4, and base 3)

    // Act
    var area = triangle.CalculateArea();
    var perimeter = triangle.CalculatePerimeter();

    // Assert
    Assert.AreEqual(10, area, "Area should be correct for specified height and base");
    Assert.AreEqual(11, perimeter, "Perimeter should be the sum of sides");
}
[TestMethod]
public void TestEquilateralTriangle()
{
    // Arrange
    var triangle = new Triangle(5, (Math.Sqrt(75)/2), 5, 5);  // base=5, height=sqrt(75)/2 for equilateral triangle

    // Act
    var area = triangle.CalculateArea();
    var perimeter = triangle.CalculatePerimeter();

    // Assert
    Assert.AreEqual(12.5, area, "Area should be consistent for equilateral triangle");
    Assert.AreEqual(15, perimeter, "Perimeter should be thrice the side length");
}
[TestMethod]
