using System.Runtime.CompilerServices;

namespace FirstStepsCSharp;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
         Циклы.
         
         for (int i = (начальное значение); (условие продолжения цикла); (действие, выполняемое после тела цикла))
         {
            Тело цикла
         }
         
         while(условие) - условие проверяется всегда после исполнения тела
         {
            Тело цикла
         }
         
         while (true) - постоянно исполнение цикла
         {+
            Тело цикла.
            Цикл не бесконечен. Из него можно выйти.
            Для этого пользуемся break или return.
            Так же из цикла выходит при какой-либо необрабатываемой ошибке.
         }
         
         Альтернатива while (true):
         for(;;)
         {
            тело цикла
         }
         
         Цикл foreach.
         foreach((тип элемента) (название элемента) in (любая коллекция))
         {
            Тело цикла. Каждый заход меняет элемент на следующий.
         }
         */

        // ПРИМЕРЫ
        for (int i = 0; i < 10; i++)
        {
           Console.WriteLine(i);
        }

        int a = 42;

        while (a > 0)
        {
           a -= 1;
        }
        
        // while (true)
        // {
        //    
        // }
        
        // for (;;)
        // {
        //    
        // }

        List<object> list = new List<object>() { true, false, 123, 523.1234 };

        foreach (object item in list)
        {
           // Тут действия с каждым элементом согласно информации выше.
        }
    }
}