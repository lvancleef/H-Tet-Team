using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelHighScoreDisplayer : MonoBehaviour
{
    public int level;
    public Text thisText;

    // Update is called once per frame
    void Update()
    {
        if(level == 1)
        {
            thisText.text = "High score: " + GameController.level1HighScore.ToString();
        }

        else if (level == 2)
        {
            thisText.text = "High score: " + GameController.level2HighScore.ToString();
        }

        else if (level == 3)
        {
            thisText.text = "High score: " + GameController.level3HighScore.ToString();
        }
    }
}
