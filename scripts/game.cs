using System;

public class Game {

    public static Action StartGame;
    public static bool canPlay = true;
    public Game () {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have a little bit more ammo.";
        Cave.StartMessage = "You have entered a cave";
        Underwater.objects = new string []{"seaweed", "Coral", "fish", "shark"};
      }
    
    // This runs at start of game.
    public void Start (){
        Console.WriteLine("Please type your name");
        name = Console.ReadLine();
        Console.WriteLine("Your Player Name is " + name + ".");
        while (canPlay){
            System.Threading.Thread.Sleep(1000);
            Play();
        }
        Console.WriteLine("you DIED!");
        Console.WriteLine("Game OVER!");
    }
    private void Play (){
        Console.WriteLine("Do you wish to continue?   "+ " Type help for help" );
       switch (GameStateMachine.currentGameState)
       {
            case GameStateMachine.GameStates.End:
                Console.WriteLine("Game OVER!");
                Environment.Exit(0);
                break;
            
            case GameStateMachine.GameStates.Help:
                Console.WriteLine("WTF do you need help for?!?!");
                Play();
                break;
            case GameStateMachine.GameStates.Play:

                break;
            default:
                Console.WriteLine("I'm sorry i don't understand what that means." );
                Play();
                break;
       }
        
        Random randomNum = new Random();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }
    
     //Game Levels
    private LevelBase Cave = new CaveLevel();
    public static LevelBase Underwater = new LevelBase();

    // game powerup
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    
    // Game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase knife = new WeaponBase();

    // game timer?
    public static void GameTimer () {
        System.Threading.Thread.Sleep(2000);
    }
    
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
