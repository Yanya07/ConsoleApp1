using System;

abstract class Shape
{
    public abstract double Area();      // Абстрактный метод для площади
    public abstract double Perimeter(); // Абстрактный метод для периметра
}

class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double Area()
    {
        return width * height;
    }
    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Program
{
    static void Main()
    {
        // Создаем объекты разных фигур
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        // Выводим площадь и периметр
        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");
        Console.ReadLine();
    }
}
