using System.Windows.Markup;

namespace Operators;

internal static class Program
{
    public static void Main(string[] args)
    {
       /*
        if (expression)
        {
            тело условия(при соблюдении expression)
        }

        switch (value):
        {
            case (вариант value):
                тело кейса. Сработает только при "value" == "вариант value"
                break; - останавливает выполнение кейса. Обычно означает конец кейса или цикла.
                Вместо break возможно воспользоваться return. Это просто выход из метода.
            case (вариант2 value):
                тело кейса. Сработает только при "value" == "вариант2 value"
                break;
            default: - может быть только 1
                Тело дефолта
                return;
        }
        
        object value = (какое-то значение) switch
        {
            (условие) => (возвращаемое значение),
            _ (нижнее подчёркивание вместо дефолта) => (возвращаемое значение)
        };
        
        => - это вместо оператора RETURN.
        */

       // Примеры IF
       int a = 52;

       if (a == 52) // условие даёт true
       {
           a = 92;
       }

       if (a == 72) // условие даёт false
       {
           a = 90;
       }
       
       if (a != 72) // условие даёт true
       {
           a = 845;
       }
       
       // отрицание лжи даёт правду (работает и в обратную сторону)
       // !false = true
       // !true = false
       if (!(a == 72)) // условие даёт true
       {
           a = 923;
       }

       //Примеры switch

       switch (a)
       {
           case 52:
               //TODO: тело при а = 52
               break;
           case 92:
               //TODO: тело при а = 92
               break;
           default:
               //TODO: тело при остальных(не указанных в кейсах) "а"
               return;
       }
       
       object value = a switch
       {
           90 => 922.52,
           52 => "Это 52", 
           _ => true
       };
    }
}