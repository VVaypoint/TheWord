using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBite : MonoBehaviour {

    private PlayerHealthScript CurrentCollider;


    public float timeBetweenBite = 2f;
    private float timestamp;


    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            CurrentCollider = other.gameObject.GetComponent<PlayerHealthScript>();
            Debug.Log("Koskettaa vihollista");

            if (CurrentCollider.tag == "Player")
            {
                /*
                Pelaaja voi hyökätä 2 sekunnin välein
                */

                if (Time.time >= timestamp && Input.GetMouseButton(0))
                {

                    Debug.Log("Mouse button pressed");
                    CurrentCollider.currentHealth = CurrentCollider.currentHealth - 25;
                    timestamp = Time.time + timeBetweenBite;
                }
            }

        }
    }
    void Update()
    {
        //Debug.Log("Aika ennen uutta iskua " + timestamp);
        //Debug.Log("Pelissä kulunut aika " + Time.time);
    }
}
