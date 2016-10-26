using System;

public class Game {

    public Game () {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have a little bit more ammo.";
      

    }

    public void Start (){
        Health.RunPowerUp();
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

    // game powerup
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    // Game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase knife = new WeaponBase();

    public string name;

    private int score;
}