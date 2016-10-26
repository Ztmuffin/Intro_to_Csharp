public class Game {

    public Game () {
        Gun.Fire();
    }

    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    public string name;

    private int score;
}