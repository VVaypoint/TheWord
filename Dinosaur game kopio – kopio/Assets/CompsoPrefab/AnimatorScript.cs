using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		
	}

    // Update is called once per frame
    public float move = 1.0f;
    void Update () {
        //float move = Input.GetAxis ("Horizontal");
        bool held = Input.GetKey(KeyCode.W);
        bool held2 = Input.GetKey(KeyCode.S);
        if (held) {
            anim.SetFloat("Speed", move);
        }
        else
        {
            anim.SetFloat("Speed", -move);
        }
        if (held2)
        {
            anim.SetFloat("BackSpeed", move);
        }
        else
        {
            anim.SetFloat("BackSpeed", -move);
        }
    }
}
