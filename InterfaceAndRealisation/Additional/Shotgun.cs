namespace InterfaceAndRealisation.Additional;

public class Shotgun : Gun, IGun
{
    public override void Shoot()
    {
        if (!AnyAmmo())
            throw new Exception("");

        Console.WriteLine("Проделан выстрел из Дробовика");
        _ammos--;
    }
}