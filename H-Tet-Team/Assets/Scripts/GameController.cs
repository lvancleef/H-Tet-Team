using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    // Data persisted between scenes
    public static bool PassedLevel2 { get; set; }
    public static bool PassedLevel3 { get; set; }

    public void passLevel2()
    {
        PassedLevel2 = true;
    }

    public void passLevel3()
    {
        PassedLevel3 = true;
    }
}
