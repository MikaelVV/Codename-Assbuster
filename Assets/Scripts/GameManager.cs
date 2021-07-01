using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " SCORE";
        highscoreText.text = " HIGHSCORE " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 20;
        scoreText.text = score.ToString() + " SCORE";
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void AddPointOnHit()
    {
        score += 3;
        scoreText.text = score.ToString() + " SCORE";
    }

    void Update()
    {
        
    }
}
