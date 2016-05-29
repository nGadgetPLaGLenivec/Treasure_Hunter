using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Start_menu : MonoBehaviour
{
    public Canvas quitMenu;
    public Button startButton;
    public Button exitButton;
    const string NEXT_LEVEL_NAME = "First_level";

    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startButton = startButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        quitMenu.enabled = false;

    }

    public void ExitPress() //this function will be used on our Exit button
    {
        quitMenu.enabled = true; //enable the Quit menu when we click the Exit button
        startButton.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
        exitButton.enabled = false;

    }

    public void NoPress() //this function will be used for our "NO" button in our Quit Menu
    {
        quitMenu.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
        startButton.enabled = true; //enable the Play and Exit buttons again so they can be clicked
        exitButton.enabled = true;

    }

    public void StartLevel() //this function will be used on our Play button
    {
        Application.LoadLevel(NEXT_LEVEL_NAME); //this will load our first level from our build settings. "1" is the second scene in our game

    }

    public void ExitGame() //This function will be used on our "Yes" button in our Quit menu
    {
        Application.Quit(); //this will quit our game. Note this will only work after building the game

    }

}
