using System;
    public class Program
    {
        
        public static Game myGame = new Game();
        public static void main(string[] args)
        {
            Console.WriteLine("Please type your name");
            myGame.name = Console.ReadLine();
            Console.WriteLine("your player name is " + myGame.name);
        }
    }
