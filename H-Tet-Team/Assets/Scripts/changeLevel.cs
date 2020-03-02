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

            if(GameController.PassedLevel2 == true && sceneName == "Tutorial 2")
            {
                Application.LoadLevel(sceneName);
            }

            else if (GameController.PassedLevel3 == true && sceneName == "Tutorial 3")
            {
                Application.LoadLevel(sceneName);
            }
        }
    }
}
