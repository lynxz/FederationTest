namespace Sub;

public class Query
{
    public Publisher GetPublisher(int id)
        => new Publisher(id, "Random House");
}

public record Publisher(int Id, string Name);
