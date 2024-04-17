using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryShapes;

var featureManagement = new Dictionary<string, string> { { "FeatureManagement:Square", "true" }, { "FeatureManagement:Rectangle", "true" }, { "FeatureManagement:Triangle", "true" } };

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

if (await featureManager.IsEnabledAsync("Square"))
{

    Console.Write("Enter the side length of the square: ");
    string input = Console.ReadLine() ?? string.Empty;
    if (double.TryParse(input, out double sideLength))
    {
        var square = new Square(sideLength);
        Console.WriteLine($"The area of the square is {square.CalculateArea()}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


if (await featureManager.IsEnabledAsync("Rectangle"))
{

    Console.Write("Enter the length of the rectangle: ");
    string input = Console.ReadLine() ?? string.Empty;
    if (double.TryParse(input, out double length))
    {
        Console.Write("Enter the width of the rectangle: ");
        input = Console.ReadLine() ?? string.Empty;
        if (double.TryParse(input, out double width))
        {
            var rectangle = new Rectangle(length, width);
            Console.WriteLine($"The area of the rectangle is {rectangle.CalculateArea()}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


if (await featureManager.IsEnabledAsync("Triangle"))
{

    Console.Write("Enter the base length of the triangle: ");
    string baseInput = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the height of the triangle: ");
    string heightInput = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the length of side A of the triangle: ");
    string sideAInput = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the length of side B of the triangle: ");
    string sideBInput = Console.ReadLine() ?? string.Empty;

    if (double.TryParse(baseInput, out double baseLength) &&
        double.TryParse(heightInput, out double height) &&
        double.TryParse(sideAInput, out double sideA) &&
        double.TryParse(sideBInput, out double sideB))
    {
        var triangle = new Triangle(baseLength, height, sideA, sideB);
        Console.WriteLine($"The area of the triangle is {triangle.CalculateArea()}");
        Console.WriteLine($"The perimeter of the triangle is {triangle.CalculatePerimeter()}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter valid numbers for all sides and height.");
    }
}