using System;

interface IDrawable
{
    void Draw();
}

class Circle : IDrawable
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем круг с радиусом {radius}");
    }
}

class Rectangle : IDrawable
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public void Draw()
    {
        Console.WriteLine($"Рисуем прямоугольник с шириной {width} и высотой {height}");
    }
}

class Triangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Рисуем треугольник");
    }
}

class Program
{
    static void Main()
    {
        // Массив объектов, реализующих интерфейс IDrawable
        IDrawable[] drawables = { new Circle(5), new Rectangle(4, 6), new Triangle() };

        foreach (IDrawable drawable in drawables)
        {
            drawable.Draw();
        }
        Console.ReadLine();
    }
}
