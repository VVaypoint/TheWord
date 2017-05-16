using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Canvas optionsMenu;
    public Button startText;
    public Button exitText;
    public Button optionsText;
    public Button audioTest;

    // Use this for initialization
    void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        optionsMenu = optionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        optionsText = exitText.GetComponent<Button>();

        quitMenu.enabled = false;
        optionsMenu.enabled = false;


    }
	
	// Poistumis menun avaus || Kyllä tai ei
	public void ExitPress () {
        quitMenu.enabled = true;
        optionsMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionsText.enabled= false;

}
    //Painoi No
    public void NoPress()
    {
        quitMenu.enabled = false;
        optionsMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionsText.enabled = true;
    }
    // Avaa options
    public void OptionsMenuOpen()
    {
        optionsMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        optionsText.enabled = false;
        // Varmistus ettei poistumis menu ole päällä
        quitMenu.enabled = false;

    }
    // Sulje options
    public void OptionsMenuClose()
    {
        optionsMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionsText.enabled = true;
        // Varmistus ettei poistumis menu ole päällä
        quitMenu.enabled = false;

    }

    //Play aloita leveli
    public void StartLevel()
    {
        SceneManager.LoadScene("MMO Camera And Player Test build");
    }
    //Painoi Yes poistu pelistä
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ChangeGualityLow() {
        QualitySettings.SetQualityLevel(1);
    }
    public void ChangeGualityMedium()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void ChangeGualityHigh()
    {
        QualitySettings.SetQualityLevel(3);
    }
    public void PlayTestMusic()
    {
        
    }
}
