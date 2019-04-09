using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_12
{
    public class Tank
    {
        public string type { get; set; }
        public int ammunition { get; set; }
        public int armor { get; set; }
        public int mobility { get; set; }

        public Tank()
        {
            type = "null";
            ammunition = 0;
            armor = 0;
            mobility = 0;

        }
        public Tank(string str, int x, int y, int z)
        {
            type = str;
            ammunition = x;
            armor = y;
            mobility = z;
        }

        public void Print()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Танк \t\t\t\t- " + type);
            Console.WriteLine("Колличество боеукладки\t\t - " + ammunition);
            Console.WriteLine("Ссумарный коэфицент брони\t - " + armor);
            Console.WriteLine("Ссумарный коэфицент маневренности - " + mobility);
            Console.WriteLine("---------------------------------");
        }
        
    }
}
