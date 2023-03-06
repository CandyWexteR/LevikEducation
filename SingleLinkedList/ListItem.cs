namespace SingleLinkedList;

/// <summary>
/// Класс, описывающий элемент списка некоторого типа Т. Тип Т - универсален, тут возможно хранить любой тип данных.
/// </summary>
/// <typeparam name="T">Тип хранимых данных</typeparam>
public class ListItem<T>
{
    protected ListItem(T value, ListItem<T>? next)
    {
        Value = value;
        Next = next;
    }

    /// <summary>
    /// Значение элемента списка
    /// </summary>
    public T Value { get; protected set; }

    /// <summary>
    /// Ссылка на следующий элемент. Не всегда имеет значение, так как следующего элемента может и не быть, потому это
    /// будет означать конец списка.
    /// </summary>
    public ListItem<T>? Next { get; protected set; }

    /// <summary>
    /// Создать элемент списка
    /// </summary>
    /// <param name="value">Значение элемента</param>
    /// <param name="next">Указатель на следующий элемент списка</param>
    /// <returns>Элемент списка со значением типа Т</returns>
    public static ListItem<T> Create(T value, ListItem<T>? next = null)
    {
        //Логика валидации, если требуется
        return new ListItem<T>(value, next);
    }

    /// <summary>
    /// Заменить текущее значение
    /// </summary>
    /// <param name="value">Значение, на которое будет заменено текущее</param>
    public void ChangeValue(T value)
    {
        Value = value;
    }

    /// <summary>
    /// Замена ссылки на следующий элемент
    /// </summary>
    /// <param name="next">Новая ссылка на следующий элемент</param>
    public void ChangeNextRef(ListItem<T>? next = null)
    {
        Next = next;
    }
}