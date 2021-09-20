using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int score = 0;

    public int shoptokens = 150;
    public int price = 2;
    public int quantity = 11;

    public bool[] itemsUnlocked;


    /* public void Awake()
     {
         shopItems = shopmanager.shopItems;
     }
     public void Start()
     {
         shopItems
     } */


    /* public Scene scene;
     public int health;
     public float[] position;

     public PlayerData(PlayerController player)
     {
         health = player.playerCurrentHealth;
         scene = player.scene;

         position = new float[2];
         position[0] = player.transform.position.x;
         position[1] = player.transform.position.y;
     } */

}
