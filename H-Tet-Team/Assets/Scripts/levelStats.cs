using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelStats : MonoBehaviour
{
    public int score;
    public int level;

    // Update is called once per frame
    void Update()
    {
        if(level == 1 && score > GameController.level1HighScore)
        {
            GameController.level1HighScore = score;
        }
    }

    public void incrementScore()
    {
        score++;
    }
}
