namespace SingleLinkedList;

public class SelfList<T>
{
    /// <summary>
    /// Индексатор. Получает СРАЗУ ЗНАЧЕНИЕ элемента с указанным индексом
    /// </summary>
    /// <param name="index">Индекс элемента списка</param>
    public T this[uint index] => Head.GetValue(index).Value;
    
    protected SelfList(ListItem<T>? head, ListItem<T>? tail, uint count)
    {
        Head = head;
        Tail = tail;
        Count = count;
    }

    /// <summary>
    /// Ссылка на первый элемент. Может являться так же и последним, либо же вовсе не быть
    /// (но тогда нет и конечного элемента)
    /// </summary>
    public ListItem<T>? Head { get; protected set; }

    /// <summary>
    /// Конечный элемент списка. Может являться так же и первым, либо же вовсе не быть
    /// (но тогда нет и начального элемента)
    /// </summary>
    public ListItem<T>? Tail { get; protected set; }

    /// <summary>
    /// Количество элементов списка
    /// </summary>
    public uint Count { get; protected set; }

    /// <summary>
    /// Метод создания списка. Первого и последнего элемента нет - список создаётся пустой. \
    /// Количество элементов так же 0.
    /// </summary>
    /// <returns>Пустой список</returns>
    public static SelfList<T> Create()
    {
        return new SelfList<T>(null, null, 0);
    }

    /// <summary>
    /// Добавление элемента. Всегда добавляет в конец.
    /// </summary>
    /// <param name="value"></param>
    public void Add(T value)
    {
        var newItem = ListItem<T>.Create(value);
        switch (Count)
        {
            case 0:
                Head = newItem;
                Tail = newItem;
                break;
            default:
                Tail.ChangeNextRef(newItem);
                Tail = newItem;
                break;
        }

        Count++;
    }

    /*
       0        1        2        3        4
     {===} >> {===} >> {===} >> {===} >> {===}
     */
    /// <summary>
    /// Удаление элемента по номеру.
    /// </summary>
    /// <param name="index">Индекс удаляемого элемента</param>
    public void Remove(uint index)
    {
        switch (index)
        {
            case 0:
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
                break;
            default:
                var value = Head.GetValue(index-1);
                var deletingValue = value.Next;
                if (deletingValue == Tail)
                {
                    Tail = value;
                }
                else
                {
                    value.ChangeNextRef(deletingValue.Next);
                }
                break;
        }

        Count--;

    }
}