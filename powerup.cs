using System;

public class PowerUp {
    int power = 10;
    int duration = 5;

    string name = "PowerUp";

    // because i made RunPowerUp public... i can access it from other scripts
        public void RunPowerUp (){
        Console.WriteLine("Using PowerUp");
    }


}