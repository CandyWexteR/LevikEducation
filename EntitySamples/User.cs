namespace EntitySamples;
/// <summary>
/// Класс пользователя соц. сети
/// </summary>
public class User
{
    private List<User> _friends;
    private List<string> _notes;
    private List<object> _photoes;

    /// <summary>
    /// Конструктор класса User. Принимает всю информацию о пользователе
    /// </summary>
    /// <param name="id"></param>
    /// <param name="username"></param>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    /// <param name="middleName"></param>
    /// <param name="status"></param>
    /// <param name="createdAt"></param>
    /// <param name="birthday"></param>
    public User(Guid id, string username, string name, string surname, string? middleName, string status,
        DateTimeOffset createdAt, DateTimeOffset birthday)
    {
        Id = id;
        Username = username;
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        Status = status;
        CreatedAt = createdAt;
        Birthday = birthday;
    }
    public Guid Id { get; protected set; }
    public string Username { get; protected set; }
    public string Name { get; protected set; }
    public string Surname { get; protected set; }
    public string? MiddleName { get; protected set; }
    public IReadOnlyList<User> Friends => _friends;
    public IReadOnlyList<string> Notes => _notes;
    public IReadOnlyList<object> Photoes => _photoes;
    public string Status { get; protected set; }
    public DateTimeOffset CreatedAt { get; protected set; }
    public DateTimeOffset Birthday { get; protected set; }

    
}