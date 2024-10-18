namespace weaponn.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon weapon = null;

            while (true)
            {
                if (weapon == null)
                {
                    Console.WriteLine("Daragin gulle tutumu ve atis sayini daxil edin");
                    Console.Write("Gulle tutumu: ");
                    int capacity = int.Parse(Console.ReadLine());
                    Console.Write("Gulle sayi: ");
                    int bulletCount = int.Parse(Console.ReadLine());
                    Console.Write("atis modu daxil edin tekli ve ya avto: ");
                    string fireMode = Console.ReadLine();

                    weapon = new Weapon(capacity, bulletCount, fireMode);
                }

                Console.WriteLine("menyu:");
                Console.WriteLine("informasiya almaq ucun 0 dAXIL EDIN");
                Console.WriteLine("1. SHOOT metodonu ise salin");
                Console.WriteLine("2 - GetRemainBulletCount metodu ise salin");
                Console.WriteLine("3 - Reload metodu ise salin");
                Console.WriteLine("4 - ChangeFireMode metodu ise salin");
                Console.WriteLine("5 - Proqramdan dayandırmaq ucun 5 daxil edin");
                
                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 0:
                        Console.WriteLine($"Güllə tutumu: {weapon.Capacity}, Güllə sayı: {weapon.BulletCount}, Atış modu: {weapon.FireMode}");
                        do { Console.WriteLine($"Gulle tutumu: {weapon.Capacity}, Gulle sayi: {weapon.BulletCount}, Atış modu: {weapon.FireMode}"); } while (weapon.Capacity > weapon.BulletCount);
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        Console.WriteLine($"Tam dolması üçün lazım olan güllə sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case 3:
                        weapon.Reload();
                        break;
                    case 4:
                        weapon.ChangeFireMode();
                        break;
                    case 5:
                        Console.WriteLine("Program dayandirilir");
                        return;

                    default:
                        Console.WriteLine("duzgun secim edin");
                        break;
                }
            }
        }
    }
}

