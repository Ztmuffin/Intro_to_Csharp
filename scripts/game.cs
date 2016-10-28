using System;

public class Game {

    public Game () {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have a little bit more ammo.";
        Cave.StartMessage = "You have entered a cave";
      }
    
    // This runs at start of game.
    public void Start (){
        Console.WriteLine("Please type your name");
        name = Console.ReadLine();
        Console.WriteLine("Your Player Name is " + name + ".");
        while (canPlay){
            Walk();
        }
        Console.WriteLine("you DIED!");
    }
    
    private void Walk (){
        Random randomNum = new Random();
        Cave.Enter();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }
     //Game Levels
    private LevelBase Cave = new LevelBase();

    // game powerup
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    
    // Game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase knife = new WeaponBase();


    public static bool canPlay = true;
    public string name;

    private int score;
}

/*
     after promt the game for a name we:
     enter a cave
     find Health.
     meet a Dragon. (need an enimy class)
     Pick Weapon.
     Battle Dragon.
     if we win: get Health and ammo
     if Dragon wins: loose Health.
     */
