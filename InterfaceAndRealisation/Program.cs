using InterfaceAndRealisation.Additional;

namespace InterfaceAndRealisation;

public static class Program
{
    public static void Main(string[] args)
    {
        IGun someGun = new Gun();
        IGun shotgun = new Shotgun();

        someGun.Reload(6);
        shotgun.Reload(6);

        someGun.Shoot();
        shotgun.Shoot();
    }
}