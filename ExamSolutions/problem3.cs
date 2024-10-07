
//This is the base case of the Shape class
public abstract class Shape
{
    public abstract double Area();
}

//creating a derived class Circle
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        // Area of circle = πr^2
        return Math.PI * radius * radius;
    }

}


//creating a derived class Rectangle
public class Rectangle : Shape
{
    private double length;
    private double breadth;

    public Rectangle(double l, double b)
    {
        this.length = l;
        this.breadth = b;
    }



    public override double Area()
    {
        // Area of Rectangle = length * breadth
        return length * breadth;
    }

}


//creating a derived class Triangle
public class Triangle : Shape
{
    private double baseOfTriangle;
    private double height;

    public Triangle(double baseOfTriangle, double height)
    {
        this.baseOfTriangle = baseOfTriangle;
        this.height = height;
    }



    public override double Area()
    {
        // Area of triangle = 1/2 * base * height
        return 0.5 * baseOfTriangle * height;
    }

}
