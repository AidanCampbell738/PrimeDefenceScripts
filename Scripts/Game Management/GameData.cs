using UnityEngine;

public static class GameData
{
    //0 means level not beaten
    //any value > 0 means level has been beaten, will display a checkmark next to the level
    //value is remaining health at the end of the level
    //if max health, gold medal is displayed
    //if > 2/3 of max health, silver medal is displayed
    public static int[] levelTracker = new int[16];
    public static int destroyedAsteroids;
    public static int currentLevel;
    public static int instructionSlide;
    public static bool asteroidMotion;
    public static bool levelClear;

    public static bool diamond;//True if diamond is active during level
    public static int diamondTime;//how long the diamond powerup is active

    public static bool goldMessage;
    public static bool perfectScore;

}

