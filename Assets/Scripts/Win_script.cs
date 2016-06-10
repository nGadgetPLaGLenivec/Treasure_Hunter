using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win_script : MonoBehaviour
{

    public Button menuButton;
    public Button exitButton;
    const string NEXT_LEVEL_NAME = "Menu";

    // Use this for initialization
    void Start()
    {
        menuButton = menuButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(GameObject.Find("Menu"));
    }

    public void ExitPress() //this function will be used on our Exit button
    {
        Application.Quit();
    }

    public void MenuLevel() //this function will be used on our Play button
    {
        SceneManager.LoadScene(NEXT_LEVEL_NAME); //this will load our first level from our build settings. "1" is the second scene in our game
    }
}
