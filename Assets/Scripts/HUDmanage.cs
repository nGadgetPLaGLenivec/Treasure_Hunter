using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class HUDmanage : MonoBehaviour
    {

        public static int treasures;        // The player's score.


        Text text;                      // Reference to the Text component.


        void Awake()
        {
            // Set up the reference.
            text = GetComponent<Text>();

            // Reset the score.
            treasures = 1;
        }
        Image img;

        void Update()
        {
            text.text = treasures.ToString();
        }
    }
}
