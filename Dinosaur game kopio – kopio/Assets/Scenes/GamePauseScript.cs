using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePauseScript : MonoBehaviour {

    public Canvas gamePauseMenu;
    public Slider Slider;
    public float SliderValue;

    private bool LockCurser;

    public Camera Camera;
    private MMOCharacterController MMOCharacterController;


    // Use this for initialization
    void Start() {
        gamePauseMenu.enabled = false;
        SliderValue = Slider.GetComponent<Slider>().normalizedValue = PlayerPrefs.GetFloat("volumeValue");
        MMOCharacterController = Camera.GetComponent<MMOCharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.Escape)) {
            gamePauseMenu.enabled = true;
            MMOCharacterController.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }

        SliderValue = Slider.GetComponent<Slider>().value;
        AudioListener.volume = SliderValue;
        PlayerPrefs.SetFloat("volumeValue", SliderValue);

    }
    public void closePlayerPauseMenu()
    {
        gamePauseMenu.enabled = false;
        MMOCharacterController.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
        MMOCharacterController.enabled = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
