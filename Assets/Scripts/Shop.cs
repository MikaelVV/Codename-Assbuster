using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject TransitionStart;
    public Animator animator;
    private Animator Page;
    public float time;
    public float time2;



    void Start()
    {
        Page = GetComponent<Animator>();

    }
    public void BackButton()
    {
        StartCoroutine("Back");
    }

    public IEnumerator Back()
    {
        animator.SetBool("Bye", true);
        yield return new WaitForSeconds(time);
        StartCoroutine("TransitionStarting");
        yield return new WaitForSeconds(time2);
        SceneManager.LoadScene("LevelSelect");
    }

    public void TransitionStarting()
    {

        TransitionStart.SetActive(true);

    }

    public void arrowRight()
        {

        Page.SetBool("Page", true);

        }
    public void arrowLeft()
    {

       Page.SetBool("Page", false);

    }

}