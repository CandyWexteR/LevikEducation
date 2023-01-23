/*
 Классы.
 
 Объявляются так:
 class Название_Класса
 {
 Тело_класса
 }
 
 Тело_класса содержит информацию об объекте, который ты хочешь создать
 Смотреть пример ниже.
 
 Тело_класса:
 {
    поля
    
    методы
    
    свойства
 }
 */

using Classes;

internal static class Program
{
    public static void Main(string[] args)
    {
        var chelovek = new Human()
        {
            MiddleName = "Аркадьевич",
            Name = "Леха",
            Surname = "Жмых"
        };
        
        Console.WriteLine(chelovek.Surname);
        Console.WriteLine(chelovek.Name);
        Console.WriteLine(chelovek.MiddleName);
        
        Console.WriteLine(chelovek.GetFullName());
        var licoObmanutoeXuliganami = new TytNazvanieKlassa();
        Console.ReadKey();
    }
}

class ExampleClass
{
    private string _ПриватноеПоле;
    private string _приватноеПолеСтрока;

    //У свойства обязательно есть геттер и сеттер - функции, выполняющие соответственно возвращение и задание значения.
    //Обычно у автосвойств есть "незримое" поле, в которое задается или из которого возвращается значение.
    public string Публичное_Свойство { get; set; }

    public string Публичное_свойство_строка
    {
        get => _приватноеПолеСтрока;
        set => _приватноеПолеСтрока = value;
    }

    public void DoSomething()
    {
        Console.WriteLine("Сделал что-то");
    }
}

class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? MiddleName { get; set; }

    public string GetFullName()
    {
        return $"{Surname} {Name} {MiddleName}";
    }
}

