using System;
public class GameStateMachine {

    public enum GameStates { Start, Play, Walk, Fight, Help, End, Died}

    public static GameStates currentGameState = GameStates.Start;
}