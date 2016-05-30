using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace CompleteProject
{
    public class Timer_manager : MonoBehaviour
    {
        public static Text timerLabel;

        private float seconds, minutes;

        void Start()
        {
            timerLabel = GetComponent<Text>() as Text;
        }

        void Update()
        {
            minutes = (int)(Time.timeSinceLevelLoad / 60f);
            seconds = (int)(Time.timeSinceLevelLoad % 60f);

            //update the label value
            timerLabel.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}