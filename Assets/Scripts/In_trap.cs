using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class In_trap : MonoBehaviour {

    private int playerHealth = 3;
    private bool playerDead = false;
    private bool playerWin = false;
    private string game_over = "Game_Over";
    private string win = "Win";
    private bool damaged;

    public GameObject player;
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    public Transform SpawnPoint4;
    public Image damageImage;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public float flashSpeed = 5f;
    public AudioSource playerHurt;    

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            damaged = true;
            playerHealth--;
            Debug.Log(playerHealth);
            CompleteProject.Health_manager.health = playerHealth;
            playerHurt.Play();
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
            SceneManager.LoadScene(game_over);
        }
    }

    void WinGame()
    {
        if (playerWin)
        {
            SceneManager.LoadScene(win);
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

