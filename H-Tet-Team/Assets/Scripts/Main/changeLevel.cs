using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLevel : MonoBehaviour
{
    public GameObject gameController;
    public void changeScene(string sceneName)

    {
        if (gameController != null)
        {
            if(sceneName == "Tutorial 1")
            {
                Application.LoadLevel(sceneName);
            }

            if(GameController.currentLevel == 2 && sceneName == "Tutorial 2")
            {
                Application.LoadLevel(sceneName);
            }

            else if (GameController.currentLevel == 3 && sceneName == "Tutorial 3")
            {
                Application.LoadLevel(sceneName);
            }
        }
    }
}
