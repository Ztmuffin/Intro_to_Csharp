using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static PowerUp Health;
        public static PowerUp Ammo;

        static string myString = "Welcome to My world";
        public static void Main(string[] args)
        {
            Health.RunPowerUp();  // because i made RunPowerUp public... i can access it from this script.
            Ammo.RunPowerUp();
           // Console.WriteLine(myString);
        }
    }
}
