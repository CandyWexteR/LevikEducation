namespace Templates.RepositorySamples;

public class HumanRepository : EntityFrameworkRepository<Human>, IHumanRepository
{
    public HumanRepository(Context context) : base(context, context.Humans)
    {
    }

    public override string NotExistsMessage => "Этот человек не найден";
    public override string AlreadyExistsMessage => "Человек с таким идентификатором уже существует";
}