using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSetting : MonoBehaviour {

    public Slider Slider;
    public float SliderValue = 1;

    // Update is called once per frame
   void Start()
    {
        SliderValue = Slider.GetComponent<Slider>().normalizedValue = PlayerPrefs.GetFloat("volumeValue"); 
    }
    void Update () {
        SliderValue = Slider.GetComponent<Slider>().value;
        AudioListener.volume = SliderValue;
        PlayerPrefs.SetFloat("volumeValue", SliderValue);
        //Debug.Log(PlayerPrefs.GetFloat("volumeValue"));
    }
}
