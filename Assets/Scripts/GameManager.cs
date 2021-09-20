using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public SavingSystem savingSystem;

    public Text scoreText;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        savingSystem.Load();
        scoreText.text = savingSystem.data.score.ToString() + " HIGHSCORE";
    }

    public void AddPointOnDeath()
    {
        savingSystem.data.score += 20;
        savingSystem.Save();
    }

    public void AddPointOnHit()
    {
        savingSystem.data.score += 3;

        scoreText.text = savingSystem.data.score.ToString() + " HIGHSCORE";
        savingSystem.Save();
    } 

    void Update()
    {

    }
}
