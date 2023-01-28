namespace Params;

public static class Program
{
    public static void Main(string[] args)
    {
        // params - эт что такое?
        /*
         params - ключевое слово, обозначающее неизвестное количество объектов в массиве.
         Известно, что массив сам по себе объявляется скобками "[]", т.е. массив целочисленных зачений - int[] values;
         */

        // var summ = Summ(new[] { 1, 2, 3, 4, 5 }, 3 - доп. аргументы писать нельзя, так как ограничено все одним массивом);
        var summ = Summ(new[] { 1, 2, 3, 4, 5 });
        var paramsSumm = ParamsSumm(34, 123, 453, 75, 91, 4, 645, 123, 234, 6, 56, 234, 867);
        var paramsSumm2 = ParamsSumm(new int[] { 34, 123, 453, 75, 91, 4, 645, 123 });
    }

    public static int Summ(int[] values) => values.Sum();

    public static int ParamsSumm(params int[] values) => values.Sum();
}