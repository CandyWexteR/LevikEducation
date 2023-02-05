﻿namespace Collections;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
         Коллекции.
         
         Коллекции - это тип данных, содержащий внутри себя какое-то количество объектов(любых)
         
         IEnumerable - общий интерфейс коллекций
         При этом бывает типизированный IEnumerable.
         
         См. пример ниже.
         */

        IEnumerable<int> ints = new List<int>()
        {
            3, 5, 6, 2, 12312, 53454
        };
        /*
         Треугольные скобки "<>" - обозначение типа данных(типа содержимого коллекции)
         */

        foreach (var intValue in ints)
        {
            //Вывод элемента коллекции
            Console.WriteLine(intValue);
            //Далее можно сделать с элементом коллекци что-то еще
        }
        
        /*
         Односвязный список
         
         При обращении к односвязному списку по названию переменной - обращаешься к первому элементу этого списка.
         Для обращения к следующему - необходимо использовать указатель на следующий элемент списка внутри значения этого списка.
         ________________________________       _________________________________       _________________________________
         | значение                     |       | значение                      |       | значение                      |
         | Ссылка на слеюущий элемент   |   =>  | Ссылка на следующий элемент   |   =>  | Ссылка на следующий элемент   | => указывает на null(ничего)
         
         Для добавления элемента в список необходимо дойти до последнего элемента и установить ссылку на следующий 
         элемент на значение ссылки добавляемого элемента. Соответсвенно ссылка на следующий элемент у добавляемого 
         значения должен будет указывать на NULL. Но бывают случаи когда значение элемента списка необходимо добавить
         не в конец, а в середину. Соответсвенно необходимо будет предусмотреть изменения ссылок в рамках списка.
         
         Двусвязный список. То же самое, что и односвязный, но у элемента есть ссылка на предыдущий элемент.
         ________________________________       _________________________________       _________________________________
         | значение                     |       | значение                      |       | значение                      |
         | Ссылка на слеюущий элемент   |   =>  | Ссылка на следующий элемент   |   =>  | Ссылка на следующий элемент   | => указывает на null(ничего)
  null <=| Ссылка на предыдущий элемент |  <=   | Ссылка на предыдущий элемент  |  <=   | Ссылка на предыдущий элемент  |
         
         */
        
        
    }
}