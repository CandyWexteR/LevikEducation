internal static class Program
{
    /*
     модификаторы_доступа тип_возвращаемого_значения название_функции(аргументы_функции)
     
     примеры:
     модификаторы_доступа = public (static), private (static), protected (static)
     
     тип_возвращаемого_значения = int, double, char, long, ИЛИ ЛЮБОЙ ТВОЙ КЛАСС
     
     название_функции = Любое название, главное чтобы отображало суть метода, иначе будет параша. Назвение метода должно
     быть уникальным, но уникальность названия еще не все. Уникальность метода подчеркивается составным ключом -
     Название + аргументы. Если одинаковое название и одинаковые агрументы - будет ошибка компиляции.
     
     аргументы_функции = Любая информация, необходимая для исполнения метода. Например, int, int[], double, double[], double[,] 
     ИЛИ ЛЮБОЙ ТВОЙ КЛАСС
     */

    public static int Summ(int value1, int value2)
    {
        //Числа суммируются. Название отображает суть.
        return value1 + value2;
    }
    
    public static void Main(string[] args)
    {
        var v1 = int.Parse(Console.ReadLine());
        var v2 = int.Parse(Console.ReadLine());

        var summaryResult = Summ(v1, v2);
        
        Console.WriteLine(summaryResult);
        Console.ReadKey();
    }
}