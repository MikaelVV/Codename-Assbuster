using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public SavingSystem savingSystem;

    public Text scoreText;
    public Text highscoreText;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        savingSystem.Load();
        scoreText.text = savingSystem.data.score.ToString() + " SCORE";
        highscoreText.text = savingSystem.data.highscore.ToString() + " HIGHSCORE";
        /*highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " SCORE";
        highscoreText.text = " HIGHSCORE " + highscore.ToString(); */
    }

    public void AddPoint()
    {
        savingSystem.data.highscore = savingSystem.data.score;
        highscoreText.text = savingSystem.data.highscore.ToString() + " SCORE";

        if(savingSystem.data.highscore < savingSystem.data.score)
        {
            highscoreText.text = savingSystem.data.highscore.ToString() + " HIGHSCORE";
        }
        savingSystem.Save();
    }

    public void AddPointOnHit()
    {
        savingSystem.data.score += 3;
        scoreText.text = savingSystem.data.score.ToString() + " SCORE";
    } 

    void Update()
    {
        AddPoint();  
    }
}
