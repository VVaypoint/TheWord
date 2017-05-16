using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBite : MonoBehaviour {

    private PlayerHealthScript Player;

    public float timeBetweenBite = 2f;
    private float timestamp;


    void Start()
    {
        // Terveys ja Pelaajan terveyden hakeminen toisesta koodi tiedostosta
        Player = GameObject.Find("Player").GetComponent<PlayerHealthScript>();

    }
    //Hyökkäys mekanismi
    void OnTriggerStay(Collider target)
    {
        if (Time.time >= timestamp)
        {
            if (target.tag == "Player")
            {

                /*
                 Hyökkäys tapahtuu 2:n sekunnin välein
                 
                 */

                //Debug.Log("Mouse button pressed");
                //Destroy (GameObject.FindWithTag ("Player"));
                Player.currentHealth = Player.currentHealth - 25;
                //Debug.Log("Isku");
                timestamp = Time.time + timeBetweenBite;
            }
        }
    }
}
