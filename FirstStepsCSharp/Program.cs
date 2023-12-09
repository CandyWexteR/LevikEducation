using System.Runtime.CompilerServices;

namespace FirstStepsCSharp;

internal static class Program
{
    public static void Main(string[] args)
    {
        /*
         Значимые типы данных
         int
         long
         char
         bool
         float
         double
         e.t.c.
         Ссылочные
         К ссылочным относят классы
         string
         Type,
         Enum,
         e.t.c.
         */
        
        // 128 (10) = 0 1 0 0 0 0 0 0 (2)
        // В знаковом формате число 
        // 0 1 0 0 0 0 0 0 (2) = 128
        // В беззнаковом
        // 0 1 0 0 0 0 0 0 (2) = 128
        
        // В знаковом формате число 
        // 1 1 0 0 0 0 0 0 (2) = -256
        // В беззнаковом
        // 1 1 0 0 0 0 0 0 (2) = 128 + 256 = 384
        
        
        // 1 + 1 = 2
        // 0 0 0 0 0 0 0 1 (2) + 0 0 0 0 0 0 0 1 (2) = 0 0 0 0 0 0 1 0
        //
        
        // (Тип данных) - например int
        // (Название переменной) - a
        // (Операция) - присваивание
        // значение - 52
        // int a = 52;
        //Банальный пример значимого типа
        
        int a = 52;
        double b = 52.285;
        
        //Банальный пример ссылочного
        Type type = typeof(Program);
    }
}