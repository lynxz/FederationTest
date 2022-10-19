namespace Main;

public class Query
{
    public Book GetBook()
        => new Book("C# in depth.", 1, new Author("Jon Skeet"));
}

public record Book(string Title, int PublisherId, Author Author);

public record Author(string Name);
