using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        { }
        public class Weapon
        {

            public string Manufacturer { get; set; }

            public int Price { get; set; }

            public void Atack()
            { Console.WriteLine("Result="); }
        }





        public class ColdSteal : Weapon
        {
            public string Material { get; set; }

            public void Sharpen()
            {
                Console.WriteLine("Result=");
            }

        }

        public class Firearm : Weapon
        {
            public int EffectiveShootingDistanse { get; set; }
            public decimal BulletSize { get; set; }

            public void Shoot()
            {
                Console.WriteLine("Result=");
            }
        }

        public class NuclearWeapon : Weapon
        {
            bool Continental { get; set; }

            public Type Attribute { get; set; }

            public void ChengeGoal()
            {
                Console.WriteLine("Result=");
            }

            public void DeliverToCoordinates()
            {
                double DeliverTo = 100000.25;

                double DeliverToCoordinates = 100000.25 * 4.0;
                Console.WriteLine(DeliverToCoordinates);


                Console.WriteLine();
            }
        }


        public class DoubleBarrel : Firearm
        {
            public bool IsShootingSports { get; set; }

            public static void Reload()
            {
                int intValue = 700;
                byte[] intBytes = BitConverter.GetBytes(intValue);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(intBytes);
                byte[] result = intBytes;
            }
        }

        public class Pistol : Firearm
        {
            public decimal Weight { get; set; }

            public static void Reload()
            {
                int intValue = 8;
                byte[] intBytes = BitConverter.GetBytes(intValue);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(intBytes);
                byte[] result = intBytes;
            }
        }


    }

    public static class ISoot
    {
        public static void Reload()
        {
            int intValue = 700;
            byte[] intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] result = intBytes;
        }
    }

}

