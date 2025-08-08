using System;
abstract class Shape
{
    public abstract void GetArea();
}
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override void GetArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of circle: {area}");
    }
}
class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override void GetArea()
    {
        double area = length * width;
        Console.WriteLine($"Area of rectangle: {area}");
    }
}