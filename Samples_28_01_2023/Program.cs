namespace Samples_28_01_2023;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------Вопрос 1------------------");
        // 1. Точка с запятой. Как работает?

        Console.WriteLine("Тут вывод в коноль");Console.WriteLine("Тут еще один вывод");
        
            //Верх и низ идетины
        
        Console.WriteLine("Тут вывод в коноль");
        Console.WriteLine("Тут еще один вывод");

        
        // 2. Default секция swtich - как работает, когда срабатывает?

        Console.WriteLine("---------------Вопрос 2------------------");
        var a = 2;

        switch (a)
        {
            case 0:
                Console.WriteLine("a=0");
                break;
            case 1:
                Console.WriteLine("a=1");
                break;
            case 2:
                Console.WriteLine("a=2");
                break;
            default:
                //Сработает если "а" не будет ни 0, ни 1, ни 2 (то есть все остальные, что не в кейсах)
                Console.WriteLine("значение А не равно ни одному из предложенных");
                break;
        }
        
        // 3. Чем отличается return от break?
        Console.WriteLine("---------------Вопрос 3------------------");
        Console.WriteLine(GetSring(0));
        Console.WriteLine(GetSring(1));
        Console.WriteLine(GetSring(2));
        Console.WriteLine(GetSring(3));
        Console.WriteLine(GetSring(-1));
    }

    public static string GetSring(int a)
    {
        switch (a)
        {
            case 0:
                // Если зайдет сюда (а=0), тогда выйдет из функции сразу. То есть Console.WriteLine() после switch
                // не сработает
                Console.WriteLine("a=0");
                return "Отработала основная кнопка";
            case 1:
            case 2:
                Console.WriteLine("a=2 или а=1");
                break;
            default:
                //Сработает если "а" не будет ни 0, ни 1, ни 2 (то есть все остальные, что не в кейсах)
                Console.WriteLine("значение А не равно ни одному из предложенных");
                break;
        }
        
        Console.WriteLine("Ну не нолик и все на этом");

        return "Основная кнопка не отработала";
    }
}