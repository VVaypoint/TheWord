using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 0.1f;
	public float rotationSpeed = 0.0f;

	void FixedUpdate () {
		float v = Input.GetAxis("Vertical") * speed;
		float h = Input.GetAxis("Horizontal") * speed;

		transform.Translate(h, 0.0f, v);
	}
}
