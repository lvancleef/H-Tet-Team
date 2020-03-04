using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeLockedSprite : MonoBehaviour
{
    public Sprite spriteToChangeTo;
    public int levelNumber;

    // Update is called once per frame
    void Update()
    {
        if(GameController.currentLevel >=  levelNumber)
        {
            this.GetComponent<Image>().sprite = spriteToChangeTo;
        }
    }
}
