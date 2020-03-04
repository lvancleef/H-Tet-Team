using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    // Data persisted between scenes
    public static bool PassedLevel2 { get; set; }
    public static bool PassedLevel3 { get; set; }

    public static int level1HighScore = 0;
    public static int level2HighScore = 0;
    public static int level3HighScore = 0;

    public static int currentLevel = 1;

    public void incrementCurrentLevel()
    {
        currentLevel ++;
    }

    public void passLevel2()
    {
        PassedLevel2 = true;
    }

    public void passLevel3()
    {
        PassedLevel3 = true;
    }
}
