using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;

    void Start()
    {
        // Terveys
        currentHealth = startingHealth;
    }

    void Update()
    {
        //Debug.Log(timestamp);
        //Debug.Log(Time.time);

        // Terveyden laskeminen nollaan tai sen alapuolelle

        if (currentHealth <= 0 ) {
            Debug.Log("Sinä kuolit");
            transform.position = new Vector3(1, 1, 1);
        }
        //Debug.Log(currentHealth);
    }
}
