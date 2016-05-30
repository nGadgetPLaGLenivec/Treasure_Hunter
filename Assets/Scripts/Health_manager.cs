using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class Health_manager : MonoBehaviour
    {

        public static int health;        // The player's health


        Image img;                      // Reference to the Text component.


        void Awake()
        {
            // Set up the reference.
            img = GetComponent<Image>();

            // Reset the score.
            health = 3;
        }

        void Update()
        {
            if (img.name == "Life3" && health == 2)
            {
                img.enabled = false;
            }
            if (img.name == "Life2" && health == 1)
            {
                img.enabled = false;
            }
            if (img.name == "Life1" && health == 0)
            {
                img.enabled = false;
            }
        }
    }
}
