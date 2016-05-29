using UnityEngine;
using System.Collections;

public class Chest_found : MonoBehaviour
{

    // Use this for initialization

    public GameObject treasure;
    //public AudioSource moneySound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(treasure);
            CompleteProject.HUDmanage.treasures--;
            //moneySound.Play();
        }
    }
}