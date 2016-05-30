using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isMenu = false;
    public string MainMenuSceneName = "Menu";
    public GUISkin mySkin;
    public MouseLook PlLook;
    public MouseLook CamLook;
    public AudioSource[] Audios;

    public void Awake()
    {
        isMenu = false;
        Time.timeScale = 1.0f;
        PlLook.enabled = true;
        CamLook.enabled = true;
        Cursor.visible  = false;
        for (int i = 0; i < Audios.Length; i++)
        {
            Audios[i].enabled = true;
        }
    }

    public void Update()
    {

        if (!isMenu && Input.GetKeyDown(KeyCode.Escape))
        {
            isMenu = true;
            Time.timeScale = 0.005f;
            PlLook.enabled = false;
            CamLook.enabled = false;
            Cursor.visible = true;
            for (int i = 0; i < Audios.Length; i++)
            {
                Audios[i].enabled = false;
            }
        }
        else if (isMenu && Input.GetKeyDown(KeyCode.Escape))
        {
            isMenu = false;
            Time.timeScale = 1.0f;
            PlLook.enabled = true;
            CamLook.enabled = true;
            Cursor.visible = false;
            for (int i = 0; i < Audios.Length; i++)
            {
                Audios[i].enabled = true;
            }
        }
    }

    public void OnGUI()
    {
        GUI.skin = mySkin;


        if (isMenu)
        {
            GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Paused", "Window");
            if (GUILayout.Button("Resume"))
            {
                isMenu = false;
                Time.timeScale = 1.0f;
                PlLook.enabled = true;
                CamLook.enabled = true;
                Cursor.visible = true;
                for (int i = 0; i < Audios.Length; i++)
                {
                    Audios[i].enabled = true;
                }
            }
            if (GUILayout.Button("Restart"))
            {
                SceneManager.LoadScene("First_level");
            }
            if (GUILayout.Button("Main Menu"))
                SceneManager.LoadScene(MainMenuSceneName);
            GUILayout.EndArea();
        }
    }
}
