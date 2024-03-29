﻿using System;
using Newtonsoft.Json;

namespace Console;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
            Консоль - статический класс. Это значит, что к нему можно обращаться по названию класса.
        
            Console.WriteLine(); - вывод с переходом на следующую строку
            Console.Write(); - вывод без перехода на следующую строку
            
            Console.Write("152");
            Console.Write("924");
            Итог: 
            152924
            
            Console.WriteLine("152");
            Console.WriteLine("924");
            Итог:
            152
            924
            
            Console.ReadLine(); - ввод с переходом на следующую строку - считывает строку
            Console.Read(); - ввод без перехода на следующую строку - считывает символ в формате ASCII
            
            
            После Console.ReadLine();
            ввел в консоль 123456 и нажал ENTER
            В строке будет следующее: string s = "123456";
         */
        
        System.Console.WriteLine("Сейчас выведу тестовую строку 123123 СЛИТНО");
        System.Console.WriteLine("123123");
        System.Console.WriteLine(123123);
        int bb = 123123;
        System.Console.WriteLine(bb);

        string consoleValue = System.Console.ReadLine();
        int consoleValue2 = System.Console.Read();
        
        // ПАРСИНГ
        /*
             Так как Console.ReadLine() считывает строку - надо приводить к нужным типам.
             У большинства есть метод Parse или TryParse, но не всегда получается привести этим способом. 
             
             var - универсальный тип. Он сам определяет что лежит внутри.
         */
        var @int = int.Parse(System.Console.ReadLine());
        var @double = double.Parse(System.Console.ReadLine());
        var @char = char.Parse(System.Console.ReadLine());
        var @char2 = char.ConvertFromUtf32(System.Console.Read());
        
        // Так же есть вариант ДЕСЕРИАЛИЗАЦИИ из строки.
        var @intT = JsonConvert.DeserializeObject<int>(System.Console.ReadLine());
        
        //e.t.c.
    }
}