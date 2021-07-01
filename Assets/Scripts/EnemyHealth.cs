using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth;
    public int enemyCurrentHealth;
    public GameObject DeathFx;
    public SpriteRenderer sprite1;

    [SerializeField]
    private Color colorToTurnTo = Color.white;


    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    
    void Update()
    {
        if(enemyCurrentHealth <= 0)
        {
            Instantiate(DeathFx, transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameManager.instance.AddPoint();
        }

    }

    public void EnemyTakingDamage(int enemyDamageTaken)
    {
        enemyCurrentHealth -= enemyDamageTaken;
        StartCoroutine("FlashColor");

    }

    public void EnemySetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    public IEnumerator FlashColor()
    {
        sprite1.color = colorToTurnTo;
        yield return new WaitForSeconds(0.1f);
        sprite1.color = Color.white;

    }
}
