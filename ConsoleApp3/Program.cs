using System;

class Author
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    public Author(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Автор: {Name}, Год рождения: {YearOfBirth}");
    }
}

class Book
{
    public string Title { get; set; }
    public int YearPublished { get; set; }
    public Author Author { get; set; }
    public Book(string title, int yearPublished, Author author)
    {
        Title = title;
        YearPublished = yearPublished;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Книга: {Title}, Год издания: {YearPublished}");
        Author.DisplayInfo();
    }
}

class Program
{
    static void Main()
    {
        // Создаем объекты авторов и книг
        Author author = new Author("Лев Толстой", 1828);
        Book book = new Book("Война и мир", 1869, author);

        book.DisplayInfo();
        Console.ReadLine();
    }
}
