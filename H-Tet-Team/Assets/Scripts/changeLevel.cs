using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLevel : MonoBehaviour
{
    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
