using UnityEngine;
using System.Collections;

public class MMOCharacterController : MonoBehaviour {

	public Transform playerCam, character, centerPoint;
	public CharacterController player;
	private float mouseX, mouseY;
	public float mouseSensitivity = 10f;
	public float mouseYPosition = 1f;

	private float moveFB, moveLR;
	public float moveSpeed = 5f;

	private float zoom;
	public float zoomSpeed = 2;

	public float zoomMin = -2f;
	public float zoomMax = -10f;

	public float rotationSpeed = 5f;

	private Vector3 tmpMousePosition;

	private float verticalVelosity;

	// Use this for initialization
	void Start () {
		tmpMousePosition = Input.mousePosition;

		zoom = -3;
		player = GetComponent<CharacterController>();

	}
	// Update is called once per frame
	void Update () {

		zoom += Input.GetAxis ("Mouse ScrollWheel") * zoomSpeed;

		if (zoom > zoomMin)
			zoom = zoomMin;

		if (zoom < zoomMax)
			zoom = zoomMax;

		playerCam.transform.localPosition = new Vector3 (0, 0, zoom);
		if (tmpMousePosition != Input.mousePosition) {
			mouseX += Input.GetAxis ("Mouse X");
			mouseY -= Input.GetAxis ("Mouse Y");
			tmpMousePosition = Input.mousePosition;
		}

		mouseY = Mathf.Clamp (mouseY, -60f, 60f);
		playerCam.LookAt (centerPoint);
		centerPoint.localRotation = Quaternion.Euler (mouseY, mouseX, 0);

		moveFB = Input.GetAxis ("Vertical") * moveSpeed;
		moveLR = Input.GetAxis ("Horizontal") * moveSpeed;



		Vector3 movement = new Vector3 (0, verticalVelosity, moveFB);
		movement = character.rotation * movement;
		character.GetComponent<CharacterController> ().Move (movement * Time.deltaTime);
		centerPoint.position = new Vector3 (character.position.x, character.position.y + mouseYPosition, character.position.z);

        if (Input.GetAxis ("Vertical") > 0 | Input.GetAxis ("Vertical") < 0) {

			Quaternion turnAngle = Quaternion.Euler (0, centerPoint.eulerAngles.y, 0);
			character.rotation = Quaternion.Slerp (character.rotation, turnAngle, Time.deltaTime * rotationSpeed);

		}
	}
	void FixedUpdate(){
		if (player.isGrounded == false) {
			verticalVelosity += Physics.gravity.y * Time.deltaTime;
		} else {
			verticalVelosity = 0f;
		}
		/*
		if (Input.GetKeyDown("Horizontal")) {
			character.transform.Rotate(Vector3(0,moveLR,0));
		}*/
	}
}