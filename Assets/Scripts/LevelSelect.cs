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

    public IEnumerator Shop()
    {
        StartCoroutine("TransitionStarting");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Shop");
    }

    public void TransitionStarting()
    {

        TransitionStart.SetActive(true);

    }
}