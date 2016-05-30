using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_Over_Buttons : MonoBehaviour {

    public Button restartButton;
    public Button exitButton;
    const string NEXT_LEVEL_NAME = "First_level";

	// Use this for initialization
	void Start () 
    {
        restartButton = restartButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
	}

    public void ExitPress() //this function will be used on our Exit button
    {
        Application.Quit();
    }

    public void RestartLevel() //this function will be used on our Play button
    {
        SceneManager.LoadScene(NEXT_LEVEL_NAME);//this will load our first level from our build settings. "1" is the second scene in our game
    }
}
