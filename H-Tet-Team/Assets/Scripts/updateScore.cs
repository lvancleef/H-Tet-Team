using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public Text score;
    public Transform mainCamera;

    // Update is called once per frame
    void Update()
    {
        score.text = mainCamera.GetComponent<levelStats>().score.ToString();
    }
}
