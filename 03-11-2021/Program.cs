using System;
using _03_11_2021.Model;

namespace _03_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string GunNAme=PrintAndReturn("Salam Silahinizin modelin" +
                " qeyd edin zehmet olmasa:");
           int Power 


            AssaultRifle assaultRifle=new AssaultRifle()





        }

        public static string PrintAndReturn(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
        public static int PrintAndReturnI(string output)
        {
            Console.WriteLine(output);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}