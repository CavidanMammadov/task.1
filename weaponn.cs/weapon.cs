using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponn.cs
{
    internal class Weapon
    {
        private int _capacity;
        private int _bulletCount;
        private string _fireMode;

        public int Capacity
        {
          
            get { return _capacity; }
            set
            {
                if (value >= 0)
                {
                    _capacity = value;
                }
                else { Console.WriteLine("capacity menfi ola bilmez"); }
            }
        }
        public int BulletCount { get { return _bulletCount; } set { if (value >= 0) { _bulletCount = value; } 
                else { Console.WriteLine("bulletcount menfi ola bilmez"); } } }
        public string FireMode { get { return _fireMode; } set { if (value == "tekli" || value == "avto") {
                    _fireMode = value;
                } } }

        public Weapon(int capacity, int bulletCount, string fireMode)
        {
            if (capacity <= 0 || bulletCount < 0 || bulletCount > capacity)
            {
                Console.WriteLine("daraqin gulle tutumini duzgun daxil edin");
            }

            Capacity = capacity;
            BulletCount = bulletCount;
            FireMode = fireMode;
        }

        public void Shoot()
        {
            if (FireMode == "tekli")
            {
                if (BulletCount >= 0)
                {
                    BulletCount--;
                    Console.WriteLine($" bir gulle atildi qalan gulle sayi:{BulletCount}");
                }
                else
                {
                    Console.WriteLine("daraqda gulle yoxdur");
                }
            }
            else if (FireMode == "avto")
            {
                if (BulletCount > 0)
                {
                    Console.WriteLine($"{BulletCount}eded gulle atildi qalan gulle sayi 0");
                    BulletCount = 0;
                }
                else
                {
                    Console.WriteLine("Daraqda gulle yixdur");
                }
            }
        }

        public int GetRemainBulletCount()
        {
            return Capacity - BulletCount;
        }

        public void Reload()
        {
            BulletCount = Capacity;
            Console.WriteLine("Daraq zarajat olundu");
        }

        public void ChangeFireMode()
        {
            FireMode = (FireMode == "tekli") ? "avto" : "tekli";
            Console.WriteLine($"atis modu deyisildi {FireMode}");
        }
    }

}

