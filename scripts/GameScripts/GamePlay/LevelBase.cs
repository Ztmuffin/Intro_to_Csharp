using System;

public class LevelBase {
    public WeaponBase m16 = new WeaponBase();
    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i){
        switch (i){
            case 1:
                Console.WriteLine("You've walked into " + objects[i]);
            break;

            case 2:
                Console.WriteLine("You've walked into " + objects[i]);
                if (objects[i] == "Shark"){
                    m16.SemiAutoFire();
                }
            break;

            case 3:
                Console.WriteLine("You've walked into " + objects[i]);
                Game.GameTimer();
                Random randomNum = new Random();
                Game.Underwater.Encounter(randomNum.Next(0, Game.Underwater.objects.Length));
            break;
        }

        if (i < objects.Length){
            Console.WriteLine("You've walked into " + objects[i]);
            if(objects[i] == "lava"){
                Game.canPlay = false;
            }
        }
        else{
            Console.WriteLine("Your path is clear.");
        }
        
    }

}