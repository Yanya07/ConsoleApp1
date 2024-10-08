using System;

class Person
{
    private string name;
    private int age;
    private string address;

    // Конструктор
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Методы для установки значений
    public void SetName(string name) { this.name = name; }
    public void SetAge(int age) { this.age = age; }
    public void SetAddress(string address) { this.address = address; }

    // Методы для получения значений
    public string GetName() { return name; }
    public int GetAge() { return age; }
    public string GetAddress() { return address; }

    // Метод для вывода информации
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Адрес: {address}");
    }
}

class Program
{
    static void Main()
    {
        // Создаем объекты класса Person
        Person person1 = new Person("Яна", 17, "Минск");
        person1.DisplayInfo();

        Person person2 = new Person("Оксана", 25, "Гомель");
        person2.DisplayInfo();
        Console.ReadLine();
    }
}
