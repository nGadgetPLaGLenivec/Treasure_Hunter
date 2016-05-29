using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class In_trap : MonoBehaviour {

    private int playerHealth = 3;
    private bool playerDead = false;
    private bool playerWin = false;
    private string game_over = "Game_Over";
    private string win = "Win";
    public GameObject player;
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    public Transform SpawnPoint4;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            playerHealth--;
            Debug.Log(playerHealth);
            CompleteProject.Health_manager.health = playerHealth;
            if (playerHealth == 0)
            {
                playerDead = true;
                EndGame();
            }
            else
            {
                Respawn();
            }
        }
        if (collision.gameObject.tag == "Finish")
        {
            playerWin = true;
            WinGame();
        }
    }
    void EndGame()
    {
        if (playerDead)
        {
            Application.LoadLevel(game_over);
        }
    }

    void WinGame()
    {
        if (playerWin)
        {
            Application.LoadLevel(win);
        }
    }

    void Respawn()
    {
        if (player.transform.position.z <= 240 
            && player.transform.position.z > 150
            && player.transform.position.x <= 298.5)
        {
            player.transform.position = SpawnPoint1.transform.position;
        }
        else if (player.transform.position.z <= 150
            && player.transform.position.x <= 315)
        {
            player.transform.position = SpawnPoint2.transform.position;
        }
        else if (player.transform.position.z >= 150 
            && player.transform.position.z < 200
            && player.transform.position.x >= 340
            && player.transform.position.x < 340)
        {
            player.transform.position = SpawnPoint3.transform.position;
        }
        else if (player.transform.position.z >= 200
            && player.transform.position.x >= 400)
        {
            player.transform.position = SpawnPoint4.transform.position;
        }
    }
}

