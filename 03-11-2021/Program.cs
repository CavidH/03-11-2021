using System;
using _03_11_2021.Model;

namespace _03_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            AssaultRifle assaultRifle= CreateGun();
            Console.WriteLine("Silahiniz yaradildi silahniz hazqinda informasiya :");
            assaultRifle.Info();






        }
        public static AssaultRifle CreateGun()
        {
            string GunNAme = PrintAndReturn("Salam Silahinizin modelin" +
                " qeyd edin zehmet olmasa:");
            int Power = PrintAndReturnI("silahnizin gucun daxil edin:");
            int AmountOfBullets = PrintAndReturnI("ne qeder gulleye ehtiyaciniz olacaq?");
            int MagazineCapacity = PrintAndReturnI("silahnizin magazin tutumu ne qeder olacaq");
            AssaultRifle assaultRifle = new AssaultRifle(GunNAme, Power, AmountOfBullets, MagazineCapacity);
            return assaultRifle;
        }
        public static string PrintAndReturn(string output)
        {
        Start:
            try
            {
                Console.WriteLine(output);
                return Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("invalid input");
            }

            goto Start;

        }
        public static int PrintAndReturnI(string output)
        {
        Start:
            try
            {
                Console.WriteLine(output);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("invalid input");
            }

            goto Start;


        }
    }
}