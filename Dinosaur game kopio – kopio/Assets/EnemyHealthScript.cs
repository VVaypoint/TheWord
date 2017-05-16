using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour {


    public int startingHealth = 100;
    public int currentHealth;

    private PlayerHealthScript Player;


    public float timeBetweenBite = 2f;
    private float timestamp;

    void Start()
    {
        // Terveys
        currentHealth = startingHealth;
    }
    void Update()
    {
        //Debug.Log(timestamp);
        //Debug.Log(Time.time);

        // Terveyden laskeminen Nollaan tai sen alapuolelle
        if (currentHealth <= 0)
        {
            Debug.Log("Vihollinen kuoli");
        }
    }
}