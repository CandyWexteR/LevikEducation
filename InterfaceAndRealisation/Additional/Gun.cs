namespace InterfaceAndRealisation.Additional;

public class Gun : IGun
{
    protected int _ammos;

    public Gun()
    {
        _ammos = 0;
    }

    protected virtual bool AnyAmmo()
    {
        return _ammos > 0;
    }
    
    public virtual void Shoot()
    {
        if (!AnyAmmo()) 
            return;
        
        Console.WriteLine("Сделан выстрел из какого-то оружия");
        _ammos--;
    }

    public virtual void Reload(int countOfAmmo)
    {
        if (countOfAmmo < 0)
        {
            return;
        }
        
        _ammos = countOfAmmo;
    }
}