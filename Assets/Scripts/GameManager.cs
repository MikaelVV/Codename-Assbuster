using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;

    int score = 0;

    void Start()
    {
        scoreText.text = score.ToString() + "Score";
    }


    void Update()
    {
        
    }
}
