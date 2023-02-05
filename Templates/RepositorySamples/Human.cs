namespace Templates.RepositorySamples;

public class Human : IdableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public uint Age { get; set; }
}