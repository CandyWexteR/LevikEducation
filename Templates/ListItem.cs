namespace Templates;

public class ListItem<T>
{
    public T Value { get; set; }
    public ListItem<T>? NextValue { get; set; }
    public ListItem<T>? PrevValue { get; set; }
}