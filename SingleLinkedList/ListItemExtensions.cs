namespace SingleLinkedList;

public static class ListItemExtensions
{
    
    /*
       0        1        2        3        4
     {===} >> {===} >> {===} >> {===} >> {===}
     Логика такова:
     Задача - найти нужный элемент списка по его номеру. Индексация начинается с 0.
     Таким образом, если запрашивается элемент с индексом 2, тогда надо 2 раза шагнуть вперёд.
     Если же запрашивается элемент с индексом 5 или более, то на 4 этапе будет ошибка: у четвертого элемента ссылка на 
     следующий элемент указывает на ничего, алгоритм продолжаться не может.
     
     Метод GetValue реализует этот алгоритм с помощью рекурсии.
     */
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="listItem"></param>
    /// <param name="index"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static ListItem<T> GetValue<T>(this ListItem<T> listItem, uint index)
    {
        if (index == 0)
        {
            return listItem;
        }

        if (listItem.Next == null)
        {
            throw new Exception("Столько даже в списке нет");
        }

        return listItem.Next.GetValue(--index);
    }
}