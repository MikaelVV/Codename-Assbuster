using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boss1 : MonoBehaviour
{
    public int bossMaxHealth;
    public int bossCurrentHealth;
    public Animator animator;
    public GameObject BossDeath;
    public GameObject BossBomb1;
    public GameObject BossBomb2;
    public GameObject BossBomb3;
    public Transform DeathSpawn;
    public Slider bosshealthbar;
    public GameObject bullet;
    public Transform firepoint;
    public Transform firepoint2;
    bool CantShoot;
    bool ShootStop;
    bool ShootIsEnabled;
    public float ShootTime;
    public SpriteRenderer sprite1;
    public SpriteRenderer sprite2;
    public bool BombLock;

    [SerializeField]
    private Color colorToTurnTo = Color.white;

    void Start()
    {
        ShootIsEnabled = false;
        bossCurrentHealth = bossMaxHealth;
        BombLock = true;
    }

    void Update()
    {
        if (CantShoot == false && ShootStop == false && ShootIsEnabled == true)
            {
            Shoot();
            }

        if (bossCurrentHealth <= 400)
        {
            BombLock = false;
            animator.SetBool("Phase2", true);
        }

        // HUOM. jos tämä on else if niin bossi ei vaihda vikaan vaiheeseen
        if (bossCurrentHealth <= 120)
        {
            ShootStop = true;
            BombLock = true;
            animator.SetBool("Phase3", true);
        }
    }
    //Ekan ja tokan vaiheen ampuminen
    public void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
        Instantiate(bullet, firepoint2.position, firepoint2.rotation);
        StartCoroutine("Cooldown");
    }

    public IEnumerator Cooldown()

    {
        CantShoot = true;
        yield return new WaitForSeconds(ShootTime);
        CantShoot = false;
    }

    //tokan vaiheen pommit. Tarvii vielä sen että randomisoi kahen pommi tyypin välillä
    //public void Bombs2()
    //{
        //tällä hetkellä particle effectin luominen spawnaa niitä pommeja aivan vitusti
        //StartCoroutine("BombCooldown");
    //}

    //public IEnumerator BombCooldown()
    //{
        //BombLock = true;
        //yield return new WaitForSeconds(BombTime);
        //BombLock = false;
    //}

    //Kolmanen vaiheen pommi
    public void Bomb3()
    {
        Instantiate(BossBomb3, transform.position, Quaternion.identity);
    }

    public void ShootEnabled()
    {
        ShootIsEnabled = true;
    }

    public void DeadCheck()
    {
        if (bossCurrentHealth <= 0)
        {
            animator.SetBool("Dying", true);
        }
    }
    public void Death()
    {

        Instantiate(BossDeath, DeathSpawn.position, DeathSpawn.rotation);
        Destroy (gameObject);
    }
    
    
    public void BossTakingDamage(int bossDamageTaken)
    {
        bossCurrentHealth -= bossDamageTaken;
        StartCoroutine("FlashColor");
    }

    public void BossSetMaxHealth()
    {
        bosshealthbar.maxValue = bossMaxHealth;
        bosshealthbar.value = bossCurrentHealth;
        bossCurrentHealth = bossMaxHealth;
    }

    public void BossSetHealth()
    {
        bosshealthbar.value = bossCurrentHealth;
    }

    public IEnumerator FlashColor()
    {
        sprite1.color = colorToTurnTo;
        sprite2.color = colorToTurnTo;
        yield return new WaitForSeconds(0.1f);
        sprite1.color = Color.white;
        sprite2.color = Color.white;
    }
}
