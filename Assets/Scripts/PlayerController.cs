using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public GameObject playerDeathFX;

    public Slider healthbar;
    public float speed;
    private Rigidbody2D rigidbody;

    public Animator animator;

    public Scene scene;

    public SpriteRenderer sprite1;

    [SerializeField]
    private Color colorToTurnTo = Color.white;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        playerCurrentHealth = playerMaxHealth;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(playerCurrentHealth <= 0)
        {
            Instantiate(playerDeathFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidbody.AddForce(movement * speed);



        //Lisää vielä keycode jolla nuolinäppäimet toimii

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Up", true);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);

            animator.SetBool("Up", false);
        }
    }

    public void SetMaxHealth()
    {
        healthbar.maxValue = playerMaxHealth;
        healthbar.value = playerCurrentHealth;
        playerCurrentHealth = playerMaxHealth;
    }

    public void SetHealth()
    {
        healthbar.value = playerCurrentHealth;
    }

    public void TakingDamage(int damageTaken)
    {
        playerCurrentHealth -= damageTaken;
        StartCoroutine("FlashColor");
    }

    public void SavePlayer()
    {
        SavingSystem.SavePlayer(this);
        PlayerPrefs.SetInt ("Level", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Tallennettu onnistuneesti");
    }

    public void LoadPlayer()
    {
        PlayerData data = SavingSystem.LoadPlayer();

        scene = data.scene;
        playerCurrentHealth = data.health;

        Vector2 position;
        position.x = data.position[0];
        position.y = data.position[1];
        transform.position = position;
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }

    public IEnumerator FlashColor()
    {
        sprite1.color = colorToTurnTo;
        yield return new WaitForSeconds(0.1f);
        sprite1.color = Color.white;

    }
}
