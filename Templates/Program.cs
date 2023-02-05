using Templates;

internal static class Program
{
    public static void Main(string[] args)
    {
        var item = new CollectionItem<int>()
        {
            Value = 152
        };
        
        Console.WriteLine(item.Value);

        var item2 = new CollectionItem2<string, double, long>()
        {
            T1Value = "asdasdasdasdasdasdasd",
            T2Value = 2323.56,
            T3Value = 123123123123
        };
        Console.WriteLine(item2.T1Value);
        Console.WriteLine(item2.T2Value);
        Console.WriteLine(item2.T3Value);
        Console.ReadKey();
    }
    
}