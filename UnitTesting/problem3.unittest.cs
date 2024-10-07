using Xunit;

public class ShapeTests
{
    [Fact]
    public void TestDifferentShapesAreas()
    {
        Shape circle = new Circle(5);           // Radius 5
        Shape rectangle = new Rectangle(4, 6);  // Length 4, Breadth 6
        Shape triangle = new Triangle(3, 4);    // Base 3, Height 4

        // Verify area calculations for Circle, Rectangle, and Triangle
        Assert.Equal(Math.PI * 25, circle.Area(), 2);         // Circle area: π * 5^2 = 78.54 (rounded)
        Assert.Equal(24, rectangle.Area());                   // Rectangle area: 4 * 6 = 24
        Assert.Equal(6, triangle.Area());                     // Triangle area: 0.5 * 3 * 4 = 6
    }

    [Fact]
    public void TestEdgeCasesForShapes()
    {
        Shape zeroCircle = new Circle(0);                     // Radius 0
        Shape negativeRectangle = new Rectangle(-4, 6);       // Negative length

        // Verify that the area is handled correctly for zero and negative dimensions
        Assert.Equal(0, zeroCircle.Area());                   // Circle area with radius 0 should be 0
        Assert.Equal(-24, negativeRectangle.Area());          // Negative length in rectangle yields negative area (-4 * 6 = -24)
    }
}
