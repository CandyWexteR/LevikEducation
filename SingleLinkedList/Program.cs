namespace SingleLinkedList;

internal static class Program
{
    public static void Main(string[] args)
    {
        var list = SelfList<int>.Create();
        
        list.Add(5); // Индекс 0
        list.Add(123); // Индекс 1
        list.Add(432); // Индекс 2
        list.Add(23); // Индекс 3
        
        Console.WriteLine(list[3]);
        
        var list2 = SelfList<string>.Create();
        
        list2.Add("тут строка с Ашибкой"); // Индекс 0
        list2.Add("строка под индексом 1"); // Индекс 1
        list2.Add("Левая строка"); // Индекс 2
        list2.Add("Двадцать три"); // Индекс 3
        
        Console.WriteLine(list2[2]);
        list2.Head.Next.Next.ChangeValue("Тут измененное значение строки");
        Console.WriteLine(list2[2]);
    }
}