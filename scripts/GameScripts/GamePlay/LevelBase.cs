using System;

public class LevelBase {

    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment;

    public string[] objects;

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i){
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