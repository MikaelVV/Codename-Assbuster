using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject TransitionStart;

    public float time;


    public void ShopButton()
    {
        StartCoroutine("Shop");
    }

    public void Level01Button()
    {
        StartCoroutine("Level01");
    }

    public void Level02Button()
    {
        StartCoroutine("Level02");
    }

    public IEnumerator Shop()
    {
        StartCoroutine("TransitionStarting");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Shop");
    }

    public IEnumerator Level01()
    {
        StartCoroutine("TransitionStarting");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Level01");
    }

    public IEnumerator Level02()
    {
        StartCoroutine("TransitionStarting");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Level02");
    }

    public void TransitionStarting()
    {

        TransitionStart.SetActive(true);

    }
}